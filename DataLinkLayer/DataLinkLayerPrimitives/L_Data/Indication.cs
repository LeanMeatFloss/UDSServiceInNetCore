namespace DataLinkLayer.DataLinkLayerPrimitives.L_Data
{
    public class Indication
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
    }
}