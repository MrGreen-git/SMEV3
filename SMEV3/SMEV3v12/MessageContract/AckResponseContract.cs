﻿using System.ComponentModel;
using System.ServiceModel;

namespace SMEV3v12.MessageContract
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(WrapperName = "AckResponse", WrapperNamespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/1.2", IsWrapped = true)]
    public class AckResponseContract
    {
        public AckResponseContract()
        {
        }
    }
}