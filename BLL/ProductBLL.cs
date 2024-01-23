using DAL.Contracts;
using MODEL;
using Config;
using MySql.Data.MySqlClient;
using System.Data;
using MODEL.Contracts;
using WFException;
using BLL.Contracts;

namespace BLL
{
    public class ProductBLL : BLL<IProduct>, IProductBLL
    {
        #region Constructor
        public ProductBLL(IProductDAL? dal) : base(dal) { }
        #endregion

        #region Methods
        #endregion

        public override async Task Add(IProduct entity)
        {
            try
            {
                await Configuration.CheckValidInput(entity);
                entity.ProductID = await Configuration.FillIDAsync(source: Configuration.ProductID.ToString(), startString: "P", idLength: 7);
                await _dal!.Add(entity);
                ++Configuration.ProductID;
            }
            catch (WrongEntityInformationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                await Configuration.WriteErrorLogAsync(ex);
            }
        }

        public override async Task Remove(int id)
        {
            try
            {
                await _dal!.Remove(id);
            }
            catch (Exception ex)
            {
                await Configuration.WriteErrorLogAsync(ex);
            }
        }

        public override async Task Update(IProduct entity)
        {
            try
            {
                await Configuration.CheckValidInput(entity);
                var dbVersion = (await _dal!.Get(x => x.ID == entity.ID))?.Version;
                if (dbVersion != null && dbVersion > entity.Version)
                    throw new DBConcurrencyException();
                await _dal!.Update(entity);
            }
            catch (DBConcurrencyException)
            {
                throw;
            }
            catch (WrongEntityInformationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                await Configuration.WriteErrorLogAsync(ex);
            }
        }
    }
}
