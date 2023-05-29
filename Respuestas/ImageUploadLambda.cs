using System;
using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Amazon.Lambda.S3Events;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

public class ImageUploadLambda
{
    public async Task FunctionHandler(S3Event evnt, ILambdaContext context)
    {
        foreach (var record in evnt.Records)
        {
            var s3Event = record.S3;
            var bucketName = s3Event.Bucket.Name;
            var objectKey = s3Event.Object.Key;

            // Aquí puedes agregar la lógica para enviar el mensaje, por ejemplo, usando un servicio de mensajería como Amazon Simple Notification Service (SNS).

            Console.WriteLine($"Nueva imagen cargada en el bucket: {bucketName}, Objeto: {objectKey}");
        }

        await Task.CompletedTask;
    }
}
