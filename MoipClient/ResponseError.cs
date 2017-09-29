using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace MoipClient
{

    /// <summary>
    /// Estrutura de retorno de mensagens do Moip
    /// </summary>
    public struct ResponseError
    {
        /// <summary>
        /// Mensagem de retorno
        /// </summary>
        public string Message { get; internal set; }

        /// <summary>
        /// Erros da mensagem, se existirem
        /// </summary>
        public ResponseDetail[] Errors { get; internal set; }


        public string FullMessage
        {
            get
            {
                var msg = "";
                if (!string.IsNullOrEmpty(Message))
                {
                    msg += Message + (Errors != null && Errors.Length > 0 ? Environment.NewLine : "");
                }

                if (Errors != null && Errors.Length > 0)
                    msg += string.Join(Environment.NewLine, Errors.Select(x => x.Description).ToArray());

                return msg;
            }
        }

    }


}
