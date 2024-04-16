using Decomposicao.Model;

namespace TestDecomposicao
{
    public class Test
    {    
        [Fact]
        public void Test1()
        {
            //Arrange
            Decompor decomporBase = new Decompor();
            decomporBase.PrimosStr = "3 5 "; ;
            decomporBase.DivisoresStr = "3 5 9 15 ";
            int numero = 45;
            Decom decom = new Decom();
            Decompor decompor = new Decompor();

            //Act
            decompor = decom.RetornoCalculoApi(numero);

            //Assert
            Assert.Equal(decomporBase.DivisoresStr,decompor.DivisoresStr);
            Assert.Equal(decomporBase.PrimosStr, decompor.PrimosStr);
        }
    }
}