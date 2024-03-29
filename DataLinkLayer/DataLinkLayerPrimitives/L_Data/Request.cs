using System;
namespace DataLinkLayer.DataLinkLayerPrimitives.L_Data
{
    /// <summary>
    /// ISO_11898-1 8.2.2.2
    /// The L_Data.Request primitive shall be passed from the LLC user to the LLC sub-layer to request that an
    /// LSDU be sent to one or more remote LLC entities.
    /// </summary>
    public class Request
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
        public virtual DataLinkLayerEnums.FormatEnum Format { get; set; }
        /// <summary>
        /// Length of the data
        /// </summary>
        /// <value></value>
        public virtual uint DLC { get; set; }
        /// <summary>
        /// Data the user wants to transmit
        /// </summary>
        /// <value></value>
        public virtual byte[] Data { get; set; }
        public DateTime HandlerTime { get; set; }
    }
}