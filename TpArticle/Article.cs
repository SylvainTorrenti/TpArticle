using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpArticle
{
    internal class Article
    {
        #region Attribute
        private static int _articleNB = 1;
        private static int _VAT = 20;
        private int _number = _articleNB;
        private int _reference;
        private string _designation;
        private double _priceET;
        private double _priceVAT;
        #endregion
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Article()
        {
            _articleNB++;
        }
        /// <summary>
        /// Constructor with Reference and Designation
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="designation"></param>
        public Article(int reference, string designation)
            : this()
        {
            _reference = reference;
            _designation = designation;
            
        }
        /// <summary>
        /// Constructor with all attribute
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="designation"></param>
        /// <param name="priceET"></param>
        /// <param name="priceVAT"></param>
        public Article(int reference, string designation, double priceET, double priceVAT)
           : this(reference,designation)
        {
            _priceET = priceET;
            _priceVAT = priceVAT;
            
        }
        /// <summary>
        /// Copi constructor
        /// </summary>
        /// <param name="article"></param>
        public Article(Article article)
            :this(article.Reference, article.Designation, article.PriceET, article.PriceVAT) 
        {
            
        }
        #endregion
        #region Get & Set Reference
        /// <summary>
        /// Reference
        /// </summary>
        public int Reference { get => _reference; set => _reference = value; }
        #endregion
        #region Get & Set Designation
        /// <summary>
        /// Designation
        /// </summary>
        public string Designation { get => _designation; set => _designation = value; }
        #endregion
        #region Get & Set PriceET
        /// <summary>
        /// PriceET
        /// </summary>
        public double PriceET { get => _priceET; set => _priceET = value; }
        #endregion
        #region Get & Set PriceVAT
        /// <summary>
        /// PriceVAT
        /// </summary>
        public double PriceVAT { get => _priceVAT; set => _priceVAT = value; }
        #endregion
        #region Get & Set Number
        /// <summary>
        /// Number
        /// </summary>
        public int Number { get => _number; set => _number = value; } 
        #endregion
        #region Method
        /// <summary>
        /// Display article
        /// </summary>
        public void DisplayArticle()
        {
            Console.WriteLine($"Article {Number} :");
            Console.WriteLine($"Référence : {Reference}");
            Console.WriteLine($"Désignation : {Designation}");
            Console.WriteLine($"Prix HT : {PriceET}");
            Console.WriteLine($"Prix TTC : {PriceVAT}");
            Console.WriteLine();
        }
        /// <summary>
        /// Calculate VAT
        /// </summary>
        /// <returns></returns>
        public double CalculateVAT()
        {
            return _priceVAT = PriceET + (PriceET * _VAT / 100);
        }
        #endregion
    }
}
