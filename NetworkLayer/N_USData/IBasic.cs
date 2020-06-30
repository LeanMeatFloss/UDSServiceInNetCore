namespace NetworkLayer.N_USData
{
    public enum MtypeEnum
    {
        Diagnostics,
        RemoteDiagnostics
    }
    public enum N_TAtypeEnum
    {
        Physical,
        Functional
    }
    public interface IBasic
    {
        /// <summary>
        /// The parameter Mtype shall be used to identify the type and range of address information parameters included in a service call.This part of ISO 15765 specifies a range of two values for this parameter.The intention is that users of this part of ISO 15765 can extend the range of values by specifying other types and combinations of address information parameters to be used with the network layer protocol specified in this part of ISO 15765. For each such new range of address information, a new value for the Mtype parameter shall be specified to identify the new address information.
        /// </summary>
        /// <value></value>
        MtypeEnum Mtype { get; }
        /// <summary>
        /// The N_SA parameter shall be used to encode the sending network layer protocol entity.
        /// </summary>
        /// <value></value>
        byte N_SA { get; }
        /// <summary>
        /// The N_TA parameter shall be used to encode one or multiple (depending on the N_TAtype:        physical or functional) receiving network layer protocol entities.
        /// </summary>
        /// <value></value>
        byte N_TA { get; }
        /// <summary>
        /// If Mtype = remote diagnostics, then the address information N_AI shall consist of the parameters N_SA, N_TA, N_TAtype, and N_AE.
        /// </summary>
        /// <value></value>
        byte N_AE { get; }
        /// <summary>
        /// The parameter N_TAtype is an extension to the N_TA parameter. It shall be used to encode the communication model used by the communicating peer entities of the network layer (see Figure 2). The following requirements shall be supported.
        /// </summary>
        /// <value></value>
        N_TAtypeEnum TA_Type { get; }
        /// <summary>
        /// This parameter includes all data that the higher-layer entities exchange.
        /// </summary>
        /// <value></value>
    }
}