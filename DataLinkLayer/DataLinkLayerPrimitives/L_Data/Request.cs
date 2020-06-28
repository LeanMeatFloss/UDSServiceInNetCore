using System;
namespace DataLinkLayerPrimitives.L_Data
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
        uint Identifier{get;set;}
        /// <summary>
        /// Frame format (CBFF, CEFF, FBFF, FEFF, optionally giving ESI and BRS bit values) 
        /// </summary>
        /// <value></value>
         uint Format{get;set;}
        uint DLC{get;set;}
        byte[] Data{get;set;}
    }
}