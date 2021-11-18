using bpls.validaSenha.API.Logica;
using Microsoft.AspNetCore.Mvc;
using System;

namespace bpls.validaSenha.API.Controllers
{
    [ApiController]
    public class SenhaController : ControllerBase
    {
        private readonly ValidaSenha _validaSenha;

        public SenhaController()
        {
            _validaSenha = new ValidaSenha();
        }

        [HttpGet("[controller]/[action]/{senha}")]
        public IActionResult IsValid(string senha)
        {
            var senhaValida = false;

            if (!String.IsNullOrWhiteSpace(senha))
            {
                if (_validaSenha.ValidaNoveOuMaisCaracteres(senha)
                    && !_validaSenha.ValidaSeExisteCaracterRepetido(senha)
                    && _validaSenha.ValidaSeExisteUmDigito(senha)
                    && _validaSenha.ValidaSeExisteUmCaracterMaiusculo(senha)
                    && _validaSenha.ValidaSeExisteUmCaracterMinusculo(senha)
                    && _validaSenha.ValidaSeExisteUmCaracterEspecial(senha)
                    && !_validaSenha.ValidaSeExisteEspacoEmBranco(senha))
                {
                    senhaValida = true;
                }    
            }

            return Ok(senhaValida);
        }
    }
}
