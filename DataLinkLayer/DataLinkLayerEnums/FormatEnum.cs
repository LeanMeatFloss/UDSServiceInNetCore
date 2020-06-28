namespace DataLinkLayer.DataLinkLayerEnums
{
    /// <summary>
    /// This enum is based on ISO_15765 table 4
    /// For describe whether the can format is.
    /// </summary>
    public enum FormatEnum
    {
        CAN_base_format,
        CAN_FD_base_format,
        CAN_extended_format,
        CAN_FD_extended_format,
    }
}