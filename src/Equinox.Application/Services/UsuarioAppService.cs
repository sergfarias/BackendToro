using System;
using AutoMapper;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Interfaces;
using Equinox.Application.Interfaces;
using Equinox.Application.ViewModels;
using Equinox.Domain.Commands.Usuario;
namespace Equinox.Application.Services
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMediatorHandler _mediator;

        public UsuarioAppService(IMapper mapper,
                                  IUsuarioRepository usuarioRepository,
                                  IMediatorHandler mediator
            )
        {
            _mapper = mapper;
            _usuarioRepository = usuarioRepository;
            _mediator = mediator;
        }

        public UsuarioViewModel GetByUsuario(string cpf, string senha)
        {
            return _mapper.Map<UsuarioViewModel>(_usuarioRepository.GetByUsuario(cpf, senha));
        }
        public UsuarioViewModel GetByUsuario(string cpf)
        {
            return _mapper.Map<UsuarioViewModel>(_usuarioRepository.GetByUsuario(cpf));
        }

        public UsuarioPosicaoViewModel GetByUsuarioPosicao(string cpf)
        {
            return _mapper.Map<UsuarioPosicaoViewModel>(_usuarioRepository.GetByUsuarioPosicao(cpf));
        }

        public void Register(UsuarioViewModel usuarioViewModel)
        {
            var registerCommand = _mapper.Map<RegisterNewUsuarioCommand>(usuarioViewModel);
            _mediator.SendCommand(registerCommand);
        }

        public bool ValidaCPF(string vrCPF)
        {
            string valor = vrCPF.Replace(".", "");
            valor = valor.Replace("-", "");

            if (valor.Length != 11)
                return false;

            bool igual = true;

            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;

            if (igual || valor == "12345678909")
                return false;

            int[] numeros = new int[11];

            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(valor[i].ToString());

            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;

            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else
                if (numeros[10] != 11 - resultado)
                return false;

            return true;
        }

        public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
}
