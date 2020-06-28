using System;
namespace DataLinkLayer.DataLinkLayerPrimitives.L_Data
{
    public class Confirm
    {
        /// <summary>
        /// Identifies the content of the frame
        /// </summary>
        /// <value></value>
        public virtual uint Identifier { get; set; }
        /// <summary>
        /// Frame format (CBFF, CEFF, FBFF, FEFF, optionally giving ESI and BRS bit values) 
        /// </summary>
        /// <value></value>
        public virtual DataLinkLayerEnums.TransferStatusEnum TransferStatus { get; set; }
        public DateTime HandlerTime { get; set; }
    }
}