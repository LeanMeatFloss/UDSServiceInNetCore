namespace DataLinkLayer
{
    public delegate void ConfirmDelegate(DataLinkLayerPrimitives.L_Data.Confirm l_Pdu);
    public delegate void IndicationDelegate(DataLinkLayerPrimitives.L_Data.Confirm l_Pdu);
    public delegate void RequestDelegate(DataLinkLayerPrimitives.L_Data.Request l_Pdu);
    public interface IDataLinkLayer
    {
        void Request(DataLinkLayer.DataLinkLayerPrimitives.L_Data.Request l_Pdu, ConfirmDelegate confirmCallback);
        event ConfirmDelegate ConfirmEvent;
        event IndicationDelegate IndicationEvent;
        event RequestDelegate RequestEvent;
        void PollingTask();
    }
}