/********* CDVAmazon.m Cordova Plugin Implementation *******/

#import <Cordova/CDV.h>

@interface CDVTest : CDVPlugin

- (void)getPluginValue:(CDVInvokedUrlCommand*)command;

@end

@implementation CDVTest

- (void)getPluginValue:(CDVInvokedUrlCommand*)command
{
    CDVPluginResult* pluginResult = nil;
    
    NSString *pluginVariable = [[[NSBundle mainBundle] infoDictionary] objectForKey:@"PluginVariable"];
   
    NSDictionary *result =[NSDictionary dictionaryWithObjectsAndKeys:pluginVariable, @"pluginVariable", nil];

    pluginResult = [CDVPluginResult resultWithStatus:CDVCommandStatus_OK messageAsDictionary:result];

    [self.commandDelegate sendPluginResult:pluginResult callbackId:command.callbackId];
}

@end
