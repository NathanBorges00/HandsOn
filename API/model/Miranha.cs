using System;

namespace xtpo
{
    public class Miranha : AHeroi
    {
        private string _poder;
        private string _uniforme;
        private string _qg;
        private string _trilhaSonora;

        public string Poder { get => _poder; set => _poder = value; }
        public string Uniforme { get => _uniforme; set => _uniforme = value; }
        public string Qg { get => _qg; set => _qg = value; }
        public string TrilhaSonora {get => _trilhaSonora; set => _trilhaSonora = value;}


    }
}