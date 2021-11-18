using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace bpls.validaSenha.Test.ValidaSenhaTests.Fixtures
{
    [CollectionDefinition(nameof(ValidaSenhaCollection))]
    public class ValidaSenhaCollection : ICollectionFixture<ValidaSenhaTestsFixtures>
    {
    }
}
