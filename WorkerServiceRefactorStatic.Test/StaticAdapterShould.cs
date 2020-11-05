using FluentAssertions;
using Moq;
using System;
using WorkerServiceRefactoreStatic.Interfaces;
using WorkerServiceRefactoreStatic.Models;
using Xunit;

namespace WorkerServiceRefactorStatic.Test
{

    public class StaticAdapterShould
    {
        private Mock<IAnotherStaticClassAdapter> _anotherStaticClassAdapter;



        public StaticAdapterShould()
        {
            _anotherStaticClassAdapter = new Mock<IAnotherStaticClassAdapter>();
        }


        [Fact]
    
        public void PrintService_Print_Message_from_Service()
        {

           
           _anotherStaticClassAdapter.Setup(x => x.GetMessage()).Returns("Print Message");
            var sut = new StaticAdapter(_anotherStaticClassAdapter.Object);

         
            var expected = "Message from Service Print Message";
          
            
            sut.PrintService();
            
            

            sut.Message.Should().Be(expected);
        }

        [Theory]
        [AutoMoqData]
        public void Print_Print_isService_False_Message_Should_Be_Null(AnotherStaticClassAdapter adapter)
        {
            var sut = new StaticAdapter(adapter);
            var expected = "Message from Service Print Message";

            sut.Print(false);

            sut.Message.Should().Be(null);
        }


        [Theory]
        [AutoMoqData]
        public void Print_Print_isService_true_Message_Should_Be_Expected(AnotherStaticClassAdapter adapter)
        {
            var sut = new StaticAdapter(adapter);
            var expected = "Message from Service Print Message";


            sut.Print(true);


            sut.Message.Should().Be(expected);
        }

    }
}
