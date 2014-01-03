using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xarala.Mairie.Spectacles
{
    /// <summary>
    /// Abstraction d'un spectacle
    /// </summary>
    public abstract class Spectacle
    {

        private string _nom;

        private DateTime _date;

        private PublicCible _publicCible; // force typo! preventing clash

        /// <summary>
        /// Constructeur de spectacle avec le nom, la date et le public cible.
        /// </summary>
        /// <param name="nom">Le nom du spectacle.</param>
        /// <param name="date">La date du spectacle (avec l'heure de début).</param>
        /// <param name="publicCible">Le public cible. <see cref="PublicCible"/></param>
        public Spectacle(string nom, DateTime date, PublicCible publicCible)
        {
            _nom      = nom;
            _date     = date;
            _publicCible = publicCible;
        }

        #region Propriétés

        public string Nom { 
            get { return _nom; } 
        }

        public PublicCible PublicCibleSpectacle
        {
            get { return _publicCible; }
        }

        #endregion

    }

    public enum PublicCible // force typo! preventing clash
    {
        Jeune = 1, 
        Adulte, 
        Tous// jeune et adulte [TODO refactoring]        
    }

}
