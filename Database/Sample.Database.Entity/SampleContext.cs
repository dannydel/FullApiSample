using Azure.Security.KeyVault.Secrets;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Database.Entity;

public class SampleContext : DbContext
{
	private SecretClient _secretClient;
	private readonly IConfiguration _config;
	public SampleContext(DbContextOptions<SampleContext> options, IConfiguration configuration, SecretClient secretClient) : base(options)
    {
		_config = configuration;
		_secretClient = secretClient;

		/*
		 * //Secret Task
		 * var secretTask = Task.Run(async () => await secretClient.GetSecretAsync("EncryptionMasterKey"));

			secretTask.Wait();

			_provider = new EncryptionProvider(secretTask.Result.Value.Value);
		 */
	}

	/* DB CONTEXTS */
}
