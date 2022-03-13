using System.ComponentModel.DataAnnotations;

namespace CardGameAPI.EnumModel
{
    public class EnumValues
    {
        public enum Cards
        {
            /// <summary>
            /// Special Cards Ranking
            /// </summary>
            [Display(Name = "4T")]
            _4T = 1,
            [Display(Name = "2T")]
            _2T,
            [Display(Name = "ST")]
            _ST,
            [Display(Name = "PT")]
            _PT,
            [Display(Name = "RT")]
            _RT,

            /// <summary>
            /// Diamond card Ranking
            /// </summary>

            [Display(Name = "2D")]
            _2D,
            [Display(Name = "3D")]
            _3D,
            [Display(Name = "4D")]
            _4D,
            [Display(Name = "5D")]
            _5D,
            [Display(Name = "6D")]
            _6D,
            [Display(Name = "7D")]
            _7D,
            [Display(Name = "8D")]
            _8D,
            [Display(Name = "9D")]
            _9D,
            [Display(Name = "10D")]
            _10D,
            [Display(Name = "JD")]
            _JD,
            [Display(Name = "QD")]
            _QD,
            [Display(Name = "KD")]
            _KD,
            [Display(Name = "AD")]
            _AD,

            /// <summary>
            /// spades card ranking
            /// </summary>
            [Display(Name = "2S")]
            _2S,
            [Display(Name = "3S")]
            _3S,
            [Display(Name = "4S")]
            _4S,
            [Display(Name = "5S")]
            _5S,
            [Display(Name = "6S")]
            _6S,
            [Display(Name = "7S")]
            _7S,
            [Display(Name = "8S")]
            _8S,
            [Display(Name = "9S")]
            _9S,
            [Display(Name = "10S")]
            _10S,
            [Display(Name = "JS")]
            _JS,
            [Display(Name = "QS")]
            _QS,
            [Display(Name = "KS")]
            _KS,
            [Display(Name = "AS")]
            _AS,

            /// <summary>
            /// clubs cards ranking
            /// </summary>
            [Display(Name = "2C")]
            _2C,
            [Display(Name = "3C")]
            _3C,
            [Display(Name = "4C")]
            _4C,
            [Display(Name = "5C")]
            _5C,
            [Display(Name = "6C")]
            _6C,
            [Display(Name = "7C")]
            _7C,
            [Display(Name = "8C")]
            _8C,
            [Display(Name = "9C")]
            _9C,
            [Display(Name = "10C")]
            _10C,
            [Display(Name = "JC")]
            _JC,
            [Display(Name = "QC")]
            _QC,
            [Display(Name = "KC")]
            _KC,
            [Display(Name = "AC")]
            _AC,

            /// <summary>
            /// hearts cards ranking
            /// </summary>
            [Display(Name = "2H")]
            _2H,
            [Display(Name = "3H")]
            _3H,
            [Display(Name = "4H")]
            _4H,
            [Display(Name = "5H")]
            _5H,
            [Display(Name = "6H")]
            _6H,
            [Display(Name = "7H")]
            _7H,
            [Display(Name = "8H")]
            _8H,
            [Display(Name = "9H")]
            _9H,
            [Display(Name = "10H")]
            _10H,
            [Display(Name = "JH")]
            _JH,
            [Display(Name = "QH")]
            _QH,
            [Display(Name = "KH")]
            _KH,
            [Display(Name = "AH")]
            _AH,
        }
    }
}
