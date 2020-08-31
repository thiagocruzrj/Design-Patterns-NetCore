using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    public class Controls : List<IControl>, IControl
    {
        public int Id { get; set; }

        public string Reader()
        {
            var sb = new StringBuilder();
            foreach (var control in this)
            {
                sb.Append($"{Id}: control: {control.Reader()}</br>");
            }

            return sb.ToString();
        }
    }
}