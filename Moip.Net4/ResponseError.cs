using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Moip.Net4
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
                    msg += Message + (Errors.Length > 0 ? Environment.NewLine : "");
                }

                msg += string.Join(Environment.NewLine, Errors.Select(x => x.Description).ToArray());

                return msg;
            }
        }

    }


}
