Xamarin bindings for the UserVoice iOS SDK.

Most of the methods/properties are bound except for those listed below as they are not currently used in [Clusterize](http://clusterize.co).

**UserVoice.h**
```objc
+ (NSBundle *)bundle;
+ (NSString *)version;
+ (void)setExternalId:(NSString *)identifier forScope:(NSString *)scope;
+ (void)track:(NSString *)event;
+ (void)track:(NSString *)event properties:(NSDictionary *)properties;
```
**UVConfig.h**
```objc
+ (UVConfig *)configWithSite:(NSString *)site andKey:(NSString *)key andSecret:(NSString *)secret;
+ (UVConfig *)configWithSite:(NSString *)site andKey:(NSString *)key andSecret:(NSString *)secret andSSOToken:(NSString *)token;
+ (UVConfig *)configWithSite:(NSString *)site andKey:(NSString *)key andSecret:(NSString *)secret andEmail:(NSString *)email andDisplayName:(NSString *)displayName andGUID:(NSString *)guid;
- (void)addAttachmentNamed:(NSString *)fileName contentType:(NSString *)contentType base64EncodedData:(NSString *)data;
- (NSArray *)attachments;
```
