namespace Cosmos.Chat.GPT.Models
{
    public class Model
    {

        public Model(string deploymentId, string name)
        {
            DeploymentId = deploymentId;
            Name = name;
        }

        public string DeploymentId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;

    }
}
