using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetCare.classes
{
    public class Animal
    {
        private String _nomeAnimal, _dataNascimentoAnimal, _genero, _raca, _especie, _numPaciente;

        public String nomeAnimal { get => _nomeAnimal; set => _nomeAnimal = value; }
        public String dataNascimentoAnimal { get => _dataNascimentoAnimal; set => _dataNascimentoAnimal = value; }
        public String genero { get => _genero; set => _genero = value; }
        public String raca { get => _raca; set => _raca = value; }
        public String especie { get => _especie; set => _especie = value; }
        public String numPaciente { get => _numPaciente; set => _numPaciente = value; }

        public override string ToString()
        {
            return _nomeAnimal +'\t'+ _dataNascimentoAnimal + '\t' + _genero + '\t' + _raca + '\t' + _especie + '\t' + _numPaciente;
        }
    }
}
