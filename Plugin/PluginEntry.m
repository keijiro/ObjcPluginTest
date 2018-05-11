#import <Foundation/Foundation.h>

void *Plugin_CreateObject(void)
{
    static int counter;
    counter++;
    NSString *s = [NSString stringWithFormat:@"counter = %d", counter++];
    return (__bridge_retained void*)s;
}

void Plugin_DestroyObject(void* pointer)
{
    NSString *s = (__bridge_transfer NSString *)pointer;
    (void)s;
}
