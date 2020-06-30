namespace NetworkLayer.N_USData
{
    public enum N_ResultEnum
    {
        N_OK,
        N_TIMEOUT_A,
        N_TIMEOUT_Bs,
        N_TIMEOUT_Cr,
        N_WRONG_SN,
        N_INVALID_FS,
        N_UNEXP_PDU,
        N_WFT_OVRN,
        N_BUFFER_OVFLW,
        N_ERROR
    }
    public interface IConfirm : IBasic
    {
        /// <summary>
        /// This parameter contains the status relating to the outcome of a service execution. If two or more errors are discovered at the same time, then the network layer entity shall use the parameter value found first in this list when indicating the error to the higher layers.
        /// </summary>
        /// <value></value>
        N_ResultEnum N_Result { get; }
    }
}