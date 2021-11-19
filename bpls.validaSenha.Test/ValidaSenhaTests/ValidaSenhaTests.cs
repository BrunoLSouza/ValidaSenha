using bpls.validaSenha.Test.ValidaSenhaTests.Fixtures;
using bpls.validaSenha.Test.XunitAttribute;
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


        [Theory(DisplayName = "Valida Se Existe Caracter Repetido")]
        [Trait("Validação Senha", "Valido")]
        [Repeat(10)]
        public void ValidaSeExisteCaracterRepetidoValido(int interation)
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaValido(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteCaracterRepetido(senha);

            //Assert
            Assert.False(resultado);

        }

        [Theory(DisplayName = "Valida Nove Ou Mais Caracteres")]
        [Trait("Validação Senha", "Valido")]
        [Repeat(10)]
        public void ValidaNoveOuMaisCaracteresValido(int interation)
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaValido(9);

            //Act
            var resultado = validaSenha.ValidaNoveOuMaisCaracteres(senha);

            //Assert
            Assert.True(resultado);

        }

        [Theory(DisplayName = "Valida Se Existe Um Digito")]
        [Trait("Validação Senha", "Valido")]
        [Repeat(10)]
        public void ValidaSeExisteUmDigitoValido(int interation)
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaValido(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteUmDigito(senha);

            //Assert
            Assert.True(resultado);

        }

        [Theory(DisplayName = "Valida Se Existe Um Caracter Minusculo")]
        [Trait("Validação Senha", "Valido")]
        [Repeat(10)]
        public void ValidaSeExisteUmCaracterMinusculoValido(int interation)
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaValido(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteUmCaracterMinusculo(senha);

            //Assert
            Assert.True(resultado);

        }

        [Theory(DisplayName = "Valida Se Existe Um Caracter Maiusculo")]
        [Trait("Validação Senha", "Valido")]
        [Repeat(10)]
        public void ValidaSeExisteUmCaracterMaiusculoValido(int interation)
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaValido(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteUmCaracterMaiusculo(senha);

            //Assert
            Assert.True(resultado);

        }

        [Theory(DisplayName = "Valida Se Existe UmCaracter Especial")]
        [Trait("Validação Senha", "Valido")]
        [Repeat(10)]
        public void ValidaSeExisteUmCaracterEspecialValido(int interation)
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaValido(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteUmCaracterEspecial(senha);

            //Assert
            Assert.True(resultado);

        }

        [Theory(DisplayName = "Valida Se Existe Espaco Em Branco")]
        [Trait("Validação Senha", "Valido")]
        [Repeat(10)]
        public void ValidaSeExisteEspacoEmBrancoValido(int interation)
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaValido(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteEspacoEmBranco(senha);

            //Assert
            Assert.False(resultado);

        }



        [Theory(DisplayName = "Valida Se Existe Caracter Repetido")]
        [Trait("Validação Senha", "Não Valido")]
        [Repeat(10)]
        public void ValidaSeExisteCaracterRepetidoNaoValido(int interation)
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaNAOValido(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteCaracterRepetido(senha);

            //Assert
            Assert.True(resultado);

        }

        [Theory(DisplayName = "Valida Nove Ou Mais Caracteres")]
        [Trait("Validação Senha", "Não Valido")]
        [Repeat(10)]
        public void ValidaNoveOuMaisCaracteresNaoValido(int interation)
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaNAOValido(8);

            //Act
            var resultado = validaSenha.ValidaNoveOuMaisCaracteres(senha);

            //Assert
            Assert.False(resultado);

        }


        [Theory(DisplayName = "Valida Se Existe Um Digito")]
        [Trait("Validação Senha", "Não Valido")]
        [Repeat(10)]
        public void ValidaSeExisteUmDigitoNaoValido(int interation)
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaSemDigito(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteUmDigito(senha);

            //Assert
            Assert.False(resultado);

        }


        [Theory(DisplayName = "Valida Se Existe Um Caracter Maiusculo")]
        [Trait("Validação Senha", "Não Valido")]
        [Repeat(10)]
        public void ValidaSeExisteUmCaracterMaiusculoNaoValido(int interation)
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaSemMaiusculo(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteUmCaracterMaiusculo(senha);

            //Assert
            Assert.False(resultado);

        }


        [Theory(DisplayName = "Valida Se Existe Um Caracter Minusculo")]
        [Trait("Validação Senha", "Não Valido")]
        [Repeat(10)]
        public void ValidaSeExisteUmCaracterMinusculoNaoValido(int interation)
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaSemMinusculo(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteUmCaracterMinusculo(senha);

            //Assert
            Assert.False(resultado);

        }

        [Theory(DisplayName = "Valida Se Existe Um Caracter Especial")]
        [Trait("Validação Senha", "Não Valido")]
        [Repeat(10)]
        public void ValidaSeExisteUmCaracterEspecialNaoValido(int interation)
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaSemCaracterEspecial(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteUmCaracterEspecial(senha);

            //Assert
            Assert.False(resultado);

        }


        [Theory(DisplayName = "Valida Se Existe Espaco Em Branco")]
        [Trait("Validação Senha", "Não Valido")]
        [Repeat(10)]
        public void ValidaSeExisteEspacoEmBrancoNaoValido(int interation)
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
