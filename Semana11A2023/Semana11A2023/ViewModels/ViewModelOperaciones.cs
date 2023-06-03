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
        public int ResultadoRestar
        {
            get { return resultadoResta; }
            set
            {
                if (resultadoResta != value)
                {
                    resultadoResta = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultadoMultiplicar;
        public int ResultadoMultiplica
        {
            get { return resultadoMultiplicar; }
            set
            {
                if (resultadoMultiplicar != value)
                {
                    resultadoMultiplicar = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultadoDividir;
        public int ResultadoDivi
        {
            get { return resultadoDividir; }
            set
            {
                if (resultadoDividir != value)
                {
                    resultadoDividir = value;
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
                ResultadoRestar = ValorA - ValorB;
            });

            Multiplica = new Command(() =>
            {
                ResultadoMultiplica = ValorA * ValorB;
            });

            Dividir = new Command(() =>
            {
                ResultadoDivi = ValorA / ValorB;
            });
        }
    }
}
