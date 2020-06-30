using NetworkLayer.N_USData;
namespace NetworkLayer.N_USData_FF
{
    public interface IIndication : IBasic
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        Uint32 Length { get; }
    }
}