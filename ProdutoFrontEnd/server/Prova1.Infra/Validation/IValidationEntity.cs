﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1.Infra.Validation
{
    /// <summary>
    /// Representa a validação de uma entidade de negócio
    /// </summary>
    public interface IValidationEntity
    {
        bool Validate();
    }
}
