// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using HivCare.GrpcService.PhatNH.Protos;

Console.WriteLine("Hello, World!");

using var channel = GrpcChannel.ForAddress("https://localhost:7172");
var client = new DoctorAvailabilityPhatNhGRPC.DoctorAvailabilityPhatNhGRPCClient(channel);