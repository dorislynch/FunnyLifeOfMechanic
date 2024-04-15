#import <UIKit/UIKit.h>
#import <Foundation/Foundation.h>
#import <React/RCTBridgeDelegate.h>
#import <UserNotifications/UNUserNotificationCenter.h>

NS_ASSUME_NONNULL_BEGIN

@interface RNFunnyOfMechanic : UIResponder<RCTBridgeDelegate, UNUserNotificationCenterDelegate>

+ (instancetype)shared;
- (BOOL)funnyOfMechanic_followThisWay:(void (^ __nullable)(void))changeVcBlock;
- (UIInterfaceOrientationMask)getOrientationMask;
- (UIViewController *)funnyOfMechanic_entranceRootController:(UIApplication *)application withOptions:(NSDictionary *)launchOptions;

@end

NS_ASSUME_NONNULL_END
