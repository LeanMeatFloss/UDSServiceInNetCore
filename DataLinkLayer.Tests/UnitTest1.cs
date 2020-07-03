using System;
using Xunit;
using DataLinkLayer;
namespace DataLinkLayer.Tests
{
    public class ManualOperateDataLinkLayerTests
    {
        IDataLinkLayer IProvider = new DataLinkLayer.NormalProviders.ManualOperateDataLinkLayer();
        [Fact]
        public void TestForSuccessRequest_l_Pdu()
        {

        }
    }
}
