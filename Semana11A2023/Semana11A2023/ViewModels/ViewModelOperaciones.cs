using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Semana11A2023.ViewModels
{
    public class ViewModelOperaciones : ViewModelBase 
    {

        int valorA;
        public int ValorA
        {
            get { return valorA; }
            set
            {
                if (valorA != value)
                {
                    valorA = value;
                    OnPropertyChanged();
                }
            }
        }


        int valorB;
        public int ValorB
        {
            get { return valorB; }
            set
            {
                if (valorB != value)
                {
                    valorB = value;
                    OnPropertyChanged();
                }
            }
        }



        int resultadoSuma;
        public int ResultadoSuma
        {
            get { return resultadoSuma; }
            set
            {
                if (resultadoSuma != value)
                {
                    resultadoSuma = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultadoResta;
        public int resultadoRestar
        {
            get { return resultadoRestar; }
            set
            {
                if (resultadoRestar != value)
                {
                    resultadoRestar = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultadoMultiplicar;
        public int resultadoMultiplica
        {
            get { return resultadoMultiplica; }
            set
            {
                if (resultadoMultiplica != value)
                {
                    resultadoMultiplica = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultadoDividir;
        public int resultadoDivi
        {
            get { return resultadoDivi; }
            set
            {
                if (resultadoDivi != value)
                {
                    resultadoDivi = value;
                    OnPropertyChanged();
                }
            }
        }



        public ICommand Sumar { protected set; get; }
        public ICommand Restar { protected set; get; }
        public ICommand Multiplica { protected set; get; }
        public ICommand Dividir { protected set; get; }


        public ViewModelOperaciones()
        {
            Sumar = new Command(() =>
            {
                ResultadoSuma = ValorA + ValorB;
            });

            Restar = new Command(() =>
            {
                resultadoRestar = ValorA - ValorB;
            });

            Restar = new Command(() =>
            {
                resultadoMultiplicar = ValorA * ValorB;
            });

            Dividir = new Command(() =>
            {
                resultadoDividir = ValorA / ValorB;
            });
        }
    }
}
