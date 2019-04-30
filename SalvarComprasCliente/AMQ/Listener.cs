using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apache.NMS;
using Newtonsoft.Json;
using SalvarComprasCliente.EF;
using Spring.Messaging.Nms.Core;

namespace SalvarComprasCliente.AMQ
{
    public class Listener : IMessageListener
    {
        
        public Listener()
        {
            Console.WriteLine("Listener created.rn");
        }
        #region IMessageListener Members

        public void OnMessage(Apache.NMS.IMessage message)
        {
            ITextMessage textMessage = message as ITextMessage;
            HistoricoCompras deserializadHistoricoCompras = JsonConvert.DeserializeObject<HistoricoCompras>(textMessage.Text.ToString());
            deserializadHistoricoCompras.GravarCompra();
           
        }

        #endregion
    }
}
