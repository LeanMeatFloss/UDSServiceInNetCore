using System.Threading;
using System.Globalization;
using System.Threading.Tasks;
using System.Linq;
using System;
namespace DataLinkLayer.NormalProviders
{
    public class ManualOperateDataLinkLayer : IDataLinkLayer
    {
        public ManualOperateDataLinkLayer()
        {

        }
        object PollingLock = new Object();
        public void PollingTask()
        {
            Task.Run(() =>
            {
                if (Monitor.TryEnter(PollingLock))
                {
                    Console.WriteLine("Select Method:\n(I):Indication (C) :Confirm (Q) :Quit");
                    string lineRead = Console.ReadLine();
                    switch (lineRead.ToLower()[0])
                    {
                        case 'i':
                            DataLinkLayerPrimitives.L_Data.Indication indication = new DataLinkLayerPrimitives.L_Data.Indication();
                            Console.WriteLine("Input Id");
                            lineRead = Console.ReadLine();
                            indication.Identifier = uint.Parse(lineRead, NumberStyles.HexNumber);
                            Console.WriteLine("Input Id");
                            lineRead = Console.ReadLine();
                            indication.Identifier = uint.Parse(lineRead, NumberStyles.HexNumber);
                            this.IndicationEvent?.Invoke(indication);
                            break;
                        case 'c':
                            Monitor.Enter(ConfirmLocker);
                            DataLinkLayerPrimitives.L_Data.Confirm confirmInfo = new DataLinkLayerPrimitives.L_Data.Confirm()
                            {

                                TransferStatus = DataLinkLayerEnums.TransferStatusEnum.Complete
                            };
                            Console.WriteLine("Is Success?Y:N");
                            lineRead = Console.ReadLine();
                            if (lineRead.Equals("N"))
                            {
                                confirmInfo.TransferStatus = DataLinkLayerEnums.TransferStatusEnum.Not_Complete;
                            }
                            Console.WriteLine("Input Id");
                            lineRead = Console.ReadLine();
                            confirmInfo.Identifier = uint.Parse(lineRead, NumberStyles.HexNumber);
                            this.ConfirmEvent?.Invoke(confirmInfo);
                            Monitor.Exit(ConfirmLocker);
                            break;
                    }
                    Monitor.Exit(PollingLock);
                }
            });


        }
        object ConfirmLocker { get; set; } = new Object();
        public void Request(DataLinkLayer.DataLinkLayerPrimitives.L_Data.Request l_Pdu, ConfirmDelegate confirmCallback)
        {
            if (l_Pdu.DLC == 0)
            {
                return;
            }
            DataLinkLayerPrimitives.L_Data.Confirm confirmInfo = new DataLinkLayerPrimitives.L_Data.Confirm()
            {
                Identifier = l_Pdu.Identifier,
                TransferStatus = DataLinkLayerEnums.TransferStatusEnum.Complete
            };
            //StartListener
            void lisenter(DataLinkLayer.DataLinkLayerPrimitives.L_Data.Confirm confirm_Pdu)
            {
                if (confirm_Pdu.Identifier.Equals(l_Pdu.Identifier))
                {
                    confirmInfo = confirm_Pdu;
                }
            }
            ConfirmEvent += lisenter;
            Console.WriteLine($"DataId:0x{l_Pdu.Identifier:X}\tDLC:{l_Pdu.DLC}\tData:{ string.Join(" ", l_Pdu.Data.Take((int)l_Pdu.DLC).Select(ele => ele.ToString("X2")))}");
            this.RequestEvent?.Invoke(l_Pdu);
            if (Monitor.TryEnter(ConfirmLocker))
            {
                this.ConfirmEvent?.Invoke(confirmInfo);
                confirmCallback(confirmInfo);
            }
            else
            {
                Monitor.Enter(ConfirmLocker);
                confirmCallback(confirmInfo);
            }
            Monitor.Exit(ConfirmLocker);
            ConfirmEvent -= lisenter;
        }
        public event ConfirmDelegate ConfirmEvent;
        public event IndicationDelegate IndicationEvent;
        public event RequestDelegate RequestEvent;
    }
}