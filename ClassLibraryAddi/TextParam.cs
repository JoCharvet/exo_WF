using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAddi
{
    public class TextParam
    {
        private string text="";
        
        private bool bGColOk = false;
        private bool charColOk = false;
        private bool caseValOk = false;

        private Color bGCol = Color.White;

        private Color charCol = Color.Black;
 
        private bool caseLower=false;
        private bool caseUpper = false;

        public string Text { get => text; set => text = value; }
       
        public bool CaseValOk { get => caseValOk;  }


        public bool CaseLower { get => caseLower;  }
        public bool CaseUpper { get => caseUpper;  }

        public TextParam() { }

        public void SetBGColOk()
        {
            this.bGColOk = (Text != "");
        }

        public void SetCharColOk()
        {
            this.charColOk = (Text != "");
        }

        public void SetCaseValOk() 
        {
            this.caseValOk = (Text != "");
        }

        public void SetBgCol(Color color)
        {
            if (this.bGColOk)
            {
                this.bGCol = color;
            }
            
        }

        public void SetCharCol(Color color) 
        {
            if (this.charColOk)
            {
                this.charCol = color;
            }   
        }

        public void SetUpperCase() 
        {
            if (this.CaseValOk)
            {
                this.caseLower = false;
                this.caseUpper=true;
            }
            
        }

        public void SetLowerCase()
        {
            if (this.CaseValOk)
            {
                this.caseUpper = false;
                this.caseLower = true;
            }
        }

    }
}
