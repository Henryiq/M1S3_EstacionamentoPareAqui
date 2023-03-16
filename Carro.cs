using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1S3_EstacionamentoPareAqui
{
    public class Carro : Veiculo
    {
        public Boolean Airbag { get; set; }
        public Boolean Radio { get; set; }
        public Boolean CameraRe { get; set; }
        public Carro(Boolean airbag, Boolean radio, Boolean cameraRe,int rapidez) : base(100,rapidez) {
            this.Airbag = airbag;
            this.Radio = radio;
            this.CameraRe = cameraRe;
        }

        public void Eixo(){

        }
    }
    
}