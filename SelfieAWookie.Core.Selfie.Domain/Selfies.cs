using SelfieAWookie.Core.Selfie.Domain;

namespace SSelfieAWookie.Core.Selfie.Domain
{
    public class Selfies
    {
        //<summary>
        //Representer un selfiea avec un wookie
        //</summary>
        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public Wookies Wookie { get; set; }
        public int WookieId {  get; set; }
        #endregion
    }
}
