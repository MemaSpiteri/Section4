using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmaSpiteri_SWD6._1B
{
    class DoublyNode<T>
    {
        public T elem { get; set; }
      
        public DoublyNode<T> Next { get; set; }
     
        public DoublyNode<T> Previous { get; set; }
    }
}
