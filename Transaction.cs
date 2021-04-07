using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLib
{
    class Transaction
    {
        public long Sender_Acc { get; set; }
        public long Receiver_Acc { get; set; }
        public string Rec_IFSC { get; set; }
        public long Amount { get; set; }
        public DateTime Transaction_time { get; set; }
    }
}
