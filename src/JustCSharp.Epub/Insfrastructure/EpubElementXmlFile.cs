using JustCSharp.Epub.Utilities;

namespace JustCSharp.Epub.Insfrastructure
{
    public abstract class EpubElementXmlFile : EpubFileSerializable
    {
        #region Properties

        

        #endregion
        
        #region Constructors
        
        
        #endregion

        #region Public Methods

        

        #endregion
        
        #region Internal & Private Methods

        protected override void OnRawDataChanged()
        {
            var newObject = _textContent.DeserializeXml(this.GetType());
            MapFrom(newObject);
        }

        protected override string BuildRawData()
        {
            return this.SerializeXml(this.GetType());
        }

        #endregion
    }
}
