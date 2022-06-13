using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWaifu
{
    class BrowserHistory
    {
        private string[] history = new string[10];
        private int historyIndex = 0;
        private int currentHistoryIndex = 0;

        public void AddToHistory(string link)
        {
            if(historyIndex < 10)
            {
                history[historyIndex] = link;
                historyIndex++;
                currentHistoryIndex = historyIndex;
            }
            else
            {
                string[] oldHistory = history;
                for (int i = 0; i < 9; i++)
                {
                    history[i] = oldHistory[i + 1];
                }
                history[9] = link;
            }
        }

        public string StepBack()
        {
            return history[currentHistoryIndex - 2];
        }

        public string FullHistory()
        {
            string fullHist = "";
            for (int i = 0; i < 10; i++)
            {
                fullHist += history[i];
                fullHist += " /n";
            }

            return fullHist;
        }

    }
}
