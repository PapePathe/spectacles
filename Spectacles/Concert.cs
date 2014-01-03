using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xarala.Mairie.Spectacles
{
    public class Concert : Spectacle
    {
        private string _stade;

        private string _artiste;

        private DateTime _heure;


        #region Constructors

        /// <summary>
        /// Constructeur à cinq arguments. 
        /// Appelle le constructeur de la classe de base
        /// <see cref="Spectacle"/>
        /// </summary>
        /// <param name="stade">Le lieu du spectacle.</param>
        /// <param name="artiste">Le nom de l'artiste ou de l'orchestre qui anime le spectacle.</param>
        /// <param name="date">La date et l'heure du spectacle.</param>
        /// <param name="nom">Le nom du spectacle.</param>
        /// <param name="publicCible">Le public cible su spectacle.</param>
        public Concert( string stade, string artiste, DateTime date, string nom, PublicCible publicCible) : base (nom, date, publicCible)
        {
            _stade = stade;
            _artiste = artiste;
            _heure = date;
        }

        #endregion


        #region Method Overrides

        /// <summary>
        /// Surcharge de la méthode ToString()
        /// </summary>
        /// <returns>string Le concert au format chaine de caractères.</returns>
        public override string ToString()
        {
            StringBuilder concert = new StringBuilder();

            concert.Append(Nom.ToUpper());
            concert.Append(String.Format("\n\tPublic Cible: {0}", PublicCibleSpectacle.ToString()));
            concert.Append("\n\tType: CONCERT");
            concert.Append(String.Format("\n\tArtiste: {0}", _artiste));
            concert.Append(String.Format("\n\tHeure: {0}:{1}", _heure.Hour, _heure.Minute));
            concert.Append(string.Format("\n\tLieu: STADE {0}", _stade.ToUpper()));

            return concert.ToString();
        }

        #endregion


    }
}
