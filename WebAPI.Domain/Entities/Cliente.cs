﻿using System;


namespace WebAPI.Domain.Entities
{
	public class Cliente :Base
	{
		public string Nome { get; set; }

		public string Email { get; set; }

		public DateTime DataDeCadastro { get; set; }

		public bool IsAtivo { get; set; }
	}
}
