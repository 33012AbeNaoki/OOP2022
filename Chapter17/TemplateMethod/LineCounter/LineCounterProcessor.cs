using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;

namespace LineCounter {
    class LineCounterProcessor : TextProcessor{

        private int _cout;

        protected override void Initialize(string fname) {
            _cout = 0;
        }

        protected override void Execute(string line) {
            _cout++;
        }

        protected override void Terminate() {
            Console.WriteLine("{0} 行", _cout);
        }

    }
}
