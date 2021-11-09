using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEZIMENAMOYPOEZD.Model
{
  public class MenuChoiceModel
    {
        public int ChoiceId { get; }
        public string ChoiceText { get; }

        public MenuChoiceModel(int choiceId, string choiceText)
        {
            ChoiceId = choiceId;
            ChoiceText = choiceText;
        }
    }
}
