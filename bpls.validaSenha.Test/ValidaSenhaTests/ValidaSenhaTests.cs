using bpls.validaSenha.Test.ValidaSenhaTests.Fixtures;
using Xunit;

namespace bpls.validaSenha.Test.ValidaSenhaTests
{
    [Collection(nameof(ValidaSenhaCollection))]
    public class ValidaSenhaTests
    {
        private readonly ValidaSenhaTestsFixtures _validaSenhaTestsFixtures;

        public ValidaSenhaTests(ValidaSenhaTestsFixtures validaSenhaTestsFixtures)
        {
            _validaSenhaTestsFixtures = validaSenhaTestsFixtures;
        }


        [Fact(DisplayName = "Valida Se Existe Caracter Repetido")]
        [Trait("Validação Senha", "Valido")]
        public void ValidaSeExisteCaracterRepetidoValido()
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaValido(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteCaracterRepetido(senha);

            //Assert
            Assert.False(resultado);

        }

        [Fact(DisplayName = "Valida Nove Ou Mais Caracteres")]
        [Trait("Validação Senha", "Valido")]
        public void ValidaNoveOuMaisCaracteresValido()
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaValido(9);

            //Act
            var resultado = validaSenha.ValidaNoveOuMaisCaracteres(senha);

            //Assert
            Assert.True(resultado);

        }

        [Fact(DisplayName = "Valida Se Existe Um Digito")]
        [Trait("Validação Senha", "Valido")]
        public void ValidaSeExisteUmDigitoValido()
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaValido(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteUmDigito(senha);

            //Assert
            Assert.True(resultado);

        }

        [Fact(DisplayName = "Valida Se Existe Um Caracter Minusculo")]
        [Trait("Validação Senha", "Valido")]
        public void ValidaSeExisteUmCaracterMinusculoValido()
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaValido(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteUmCaracterMinusculo(senha);

            //Assert
            Assert.True(resultado);

        }

        [Fact(DisplayName = "Valida Se Existe Um Caracter Maiusculo")]
        [Trait("Validação Senha", "Valido")]
        public void ValidaSeExisteUmCaracterMaiusculoValido()
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaValido(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteUmCaracterMaiusculo(senha);

            //Assert
            Assert.True(resultado);

        }

        [Fact(DisplayName = "Valida Se Existe UmCaracter Especial")]
        [Trait("Validação Senha", "Valido")]
        public void ValidaSeExisteUmCaracterEspecialValido()
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaValido(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteUmCaracterEspecial(senha);

            //Assert
            Assert.True(resultado);

        }

        [Fact(DisplayName = "Valida Se Existe Espaco Em Branco")]
        [Trait("Validação Senha", "Valido")]
        public void ValidaSeExisteEspacoEmBrancoValido()
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaValido(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteEspacoEmBranco(senha);

            //Assert
            Assert.False(resultado);

        }



        [Fact(DisplayName = "Valida Se Existe Caracter Repetido")]
        [Trait("Validação Senha", "Não Valido")]
        public void ValidaSeExisteCaracterRepetidoNaoValido()
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaNAOValido(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteCaracterRepetido(senha);

            //Assert
            Assert.True(resultado);

        }

        [Fact(DisplayName = "Valida Nove Ou Mais Caracteres")]
        [Trait("Validação Senha", "Não Valido")]
        public void ValidaNoveOuMaisCaracteresNaoValido()
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaNAOValido(8);

            //Act
            var resultado = validaSenha.ValidaNoveOuMaisCaracteres(senha);

            //Assert
            Assert.False(resultado);

        }


        [Fact(DisplayName = "Valida Se Existe Um Digito")]
        [Trait("Validação Senha", "Não Valido")]
        public void ValidaSeExisteUmDigitoNaoValido()
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaSemDigito(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteUmDigito(senha);

            //Assert
            Assert.False(resultado);

        }


        [Fact(DisplayName = "Valida Se Existe Um Caracter Maiusculo")]
        [Trait("Validação Senha", "Não Valido")]
        public void ValidaSeExisteUmCaracterMaiusculoNaoValido()
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaSemMaiusculo(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteUmCaracterMaiusculo(senha);

            //Assert
            Assert.False(resultado);

        }


        [Fact(DisplayName = "Valida Se Existe Um Caracter Minusculo")]
        [Trait("Validação Senha", "Não Valido")]
        public void ValidaSeExisteUmCaracterMinusculoNaoValido()
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaSemMinusculo(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteUmCaracterMinusculo(senha);

            //Assert
            Assert.False(resultado);

        }

        [Fact(DisplayName = "Valida Se Existe Um Caracter Especial")]
        [Trait("Validação Senha", "Não Valido")]
        public void ValidaSeExisteUmCaracterEspecialNaoValido()
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaSemCaracterEspecial(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteUmCaracterEspecial(senha);

            //Assert
            Assert.False(resultado);

        }


        [Fact(DisplayName = "Valida Se Existe Espaco Em Branco")]
        [Trait("Validação Senha", "Não Valido")]
        public void ValidaSeExisteEspacoEmBrancoNaoValido()
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaNAOValido(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteEspacoEmBranco(senha);

            //Assert
            Assert.True(resultado);

        }

    }
}
