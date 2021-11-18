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

        [Fact(DisplayName = "Valida Senha - Valido")]
        [Trait("Validação", "Valida Senha")]
        public void ValidaSenhaValido()
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaValido(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteCaracterRepetido(senha);

            //Assert
            Assert.False(resultado);

        }


        [Fact(DisplayName = "Valida Senha - Não Valido")]
        [Trait("Validação", "Valida Senha")]
        public void ValidaSenhaNaoValido()
        {
            //Arrange
            var validaSenha = _validaSenhaTestsFixtures.CriaValidaSenha();
            var senha = _validaSenhaTestsFixtures.GerarSenhaNAOValido(9);

            //Act
            var resultado = validaSenha.ValidaSeExisteCaracterRepetido(senha);

            //Assert
            Assert.True(resultado);

        }

    }
}
