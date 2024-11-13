using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vecchi_cassaforte
{
    internal class Cassaforte
    {
        private int numMatricola;
        public int NumMatricola
        {
            get { return numMatricola; }
        }

        private string produttore;
        public string Produttore
        {
            get { return produttore; }
        }

        private string modello;
        public string Modello
        {
            get { return modello; }
        }

        private string codiceSblocco;
        public string CodiceSblocco
        {
            get { return codiceSblocco; }
        }

        private int codiceUtente;
        public int CodiceUtente
        {
            get { return codiceUtente; } //set non necessario , tramite metodo
        }

        private bool isOpen;
        public bool IsOpen
        {
            get { return isOpen; }
        }

        private int tentativi;
        public int Tentativi
        {
            get { return tentativi; }
        }

        private string dataProg;
        public string DataProg
        {
            get { return dataProg; }
        }

        private string dataOggi;
        public string DataOggi
        {
            get { return dataOggi; }
            set { dataOggi = value; }
        }

        public void ImpostaCod(int newCode)
        {
            codiceUtente = newCode;
        }

        public void Apri(int codice)
        {
            if (!IsOpen) {
                if (tentativi < 5)
                {
                    if (codice == codiceUtente)
                    {
                        isOpen = true;
                        tentativi = 0;
                    }
                    else
                    {
                        tentativi++;
                    }
                }
            }
        }

        public void Chiudi()
        {
            if (isOpen)
            {
                tentativi = 0; //una volta che era aperta, quando chiudo reset tentativi
                isOpen = false;
            }
            
        }

        public void Sblocca(string codice)
        {
            if(codice == codiceSblocco)
            {
                tentativi = 0;
                isOpen = true;
            }
        }

        public void ImpostaData(string newData)
        {

            dataProg = newData;
        }
        
        public void ApriProg(int codice, string dataOggi, string dataProg)
        {
            if (dataOggi == dataProg)
            {
                Apri(codice);
            }
        }

        public Cassaforte(int numMatricola, string produttore, string modello, string codiceSblocco, int tentativi)
        {
            this.numMatricola = numMatricola;
            this.produttore = produttore;
            this.modello = modello;
            this.codiceSblocco = codiceSblocco;
            this.tentativi = tentativi; //tentativi è variabile ma utile averlo nel costruttore per inizializzare a 0
        }
    }
    
}
