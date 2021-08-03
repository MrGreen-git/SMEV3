﻿using System.ComponentModel;
using System.ServiceModel;

namespace SMEV3v11.MessageContract
{
    /// <summary>
    /// Возвращаемое значение метода "Подтверждение получения сообщения".
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "AckResponse", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.1", IsWrapped = true)]
    public class AckResponseContract
    {
        public AckResponseContract()
        {
        }
    }
}
