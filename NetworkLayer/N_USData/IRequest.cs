using System;
using System.Collections.Generic;
namespace NetworkLayer.N_USData
{

    public interface IRequest : IBasic
    {

        IReadOnlyList<byte> MessageData { get; }
        /// <summary>
        /// This parameter includes the length of data to be transmitted/received.
        /// </summary>
        /// <value></value>
        UInt32 Length { get; }

    }
}