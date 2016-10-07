using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC
{
    public class ClassIntervalo
    {
        public ClassIntervalo()
        {

        }
        private double double_0;

        private double double_1;

        public double dLimiteInferior
        {
            get
            {
                return this.double_0;
            }
            set
            {
                this.double_0 = value;
            }
        }

        public double dLimiteSuperior
        {
            get
            {
                return this.double_1;
            }
            set
            {
                this.double_1 = value;
            }
        }
    }
}
