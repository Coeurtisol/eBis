using eBis.common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBis.ViewModels
{
    public class OperationViewModel
    {
        private Operation _operation;

        public OperationViewModel(Operation operation)
        {
            _operation = operation;
        }

        public string TypeDeCharge
        {
            get => _operation.TypeDeCharge;
        }

        public DateTime DateDebutCharge
        {
            get => _operation.DateDebutCharge;
        }

        public DateTime DateFinCharge
        {
            get => _operation.DateFinCharge;
        }

        public double KWConsommes
        {
            get => _operation.KWConsommes;
        }

        public string Borne
        {
            get => _operation.Borne;
        }


    }
}
