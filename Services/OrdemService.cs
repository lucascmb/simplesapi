using DesafioBahia.Domain.Models;
using DesafioBahia.Domain.Repositories;
using DesafioBahia.Domain.Services;
using DesafioBahia.Domain.Validator;
using DesafioBahia.Resources;
using DesafioBahia.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace DesafioBahia.Services
{
    public class OrdemService : IOrdemService
    {
        private readonly IOrdemRepository _ordemRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOrdemValidator _ordemValidator;

        public OrdemService(IOrdemRepository ordemRepository, IUnitOfWork unityOfWork, IOrdemValidator ordemValidator)
        {
            _ordemRepository = ordemRepository;
            _unitOfWork = unityOfWork;
            _ordemValidator = ordemValidator;
        }

        public async Task<IEnumerable<Ordem>> ListAsync()
        {
            return await _ordemRepository.ListAsync();
        }

        public async Task<IEnumerable<Ordem>> ByDateRangeListAsync(DateTime dataInicial, DateTime dataFinal)
        {
            return await _ordemRepository.ByDateRangeListAsync(dataInicial, dataFinal);
        }

        public async Task<SaveOrdemResponse> SaveAsync(Ordem ordem)
        {
            try
            {
                await _ordemRepository.AddAsync(ordem);

                if (_ordemValidator.CheckOrdemRules(ordem))
                {
                    await _unitOfWork.CompleteAsync();
                }

                return new SaveOrdemResponse(ordem);
            }
            catch(Exception ex)
            {
                return new SaveOrdemResponse($"Error : {ex.Message}");
            }
        }
    }
}
