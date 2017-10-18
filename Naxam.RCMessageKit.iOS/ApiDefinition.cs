using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace RCMessageKit
{
	// @interface RCMessages : NSObject
	[BaseType(typeof(NSObject))]
	interface RCMessages
	{
		// @property (assign, nonatomic) CGFloat sectionHeaderMargin;
		[Export("sectionHeaderMargin")]
		nfloat SectionHeaderMargin { get; set; }

		// @property (assign, nonatomic) CGFloat sectionHeaderHeight;
		[Export("sectionHeaderHeight")]
		nfloat SectionHeaderHeight { get; set; }

		// @property (assign, nonatomic) CGFloat sectionHeaderLeft;
		[Export("sectionHeaderLeft")]
		nfloat SectionHeaderLeft { get; set; }

		// @property (assign, nonatomic) CGFloat sectionHeaderRight;
		[Export("sectionHeaderRight")]
		nfloat SectionHeaderRight { get; set; }

		// @property (nonatomic, strong) UIColor * sectionHeaderColor;
		[Export("sectionHeaderColor", ArgumentSemantic.Strong)]
		UIColor SectionHeaderColor { get; set; }

		// @property (nonatomic, strong) UIFont * sectionHeaderFont;
		[Export("sectionHeaderFont", ArgumentSemantic.Strong)]
		UIFont SectionHeaderFont { get; set; }

		// @property (assign, nonatomic) CGFloat sectionFooterHeight;
		[Export("sectionFooterHeight")]
		nfloat SectionFooterHeight { get; set; }

		// @property (assign, nonatomic) CGFloat sectionFooterLeft;
		[Export("sectionFooterLeft")]
		nfloat SectionFooterLeft { get; set; }

		// @property (assign, nonatomic) CGFloat sectionFooterRight;
		[Export("sectionFooterRight")]
		nfloat SectionFooterRight { get; set; }

		// @property (nonatomic, strong) UIColor * sectionFooterColor;
		[Export("sectionFooterColor", ArgumentSemantic.Strong)]
		UIColor SectionFooterColor { get; set; }

		// @property (nonatomic, strong) UIFont * sectionFooterFont;
		[Export("sectionFooterFont", ArgumentSemantic.Strong)]
		UIFont SectionFooterFont { get; set; }

		// @property (assign, nonatomic) CGFloat sectionFooterMargin;
		[Export("sectionFooterMargin")]
		nfloat SectionFooterMargin { get; set; }

		// @property (assign, nonatomic) CGFloat bubbleHeaderHeight;
		[Export("bubbleHeaderHeight")]
		nfloat BubbleHeaderHeight { get; set; }

		// @property (assign, nonatomic) CGFloat bubbleHeaderLeft;
		[Export("bubbleHeaderLeft")]
		nfloat BubbleHeaderLeft { get; set; }

		// @property (assign, nonatomic) CGFloat bubbleHeaderRight;
		[Export("bubbleHeaderRight")]
		nfloat BubbleHeaderRight { get; set; }

		// @property (nonatomic, strong) UIColor * bubbleHeaderColor;
		[Export("bubbleHeaderColor", ArgumentSemantic.Strong)]
		UIColor BubbleHeaderColor { get; set; }

		// @property (nonatomic, strong) UIFont * bubbleHeaderFont;
		[Export("bubbleHeaderFont", ArgumentSemantic.Strong)]
		UIFont BubbleHeaderFont { get; set; }

		// @property (assign, nonatomic) CGFloat bubbleMarginLeft;
		[Export("bubbleMarginLeft")]
		nfloat BubbleMarginLeft { get; set; }

		// @property (assign, nonatomic) CGFloat bubbleMarginRight;
		[Export("bubbleMarginRight")]
		nfloat BubbleMarginRight { get; set; }

		// @property (assign, nonatomic) CGFloat bubbleRadius;
		[Export("bubbleRadius")]
		nfloat BubbleRadius { get; set; }

		// @property (assign, nonatomic) CGFloat bubbleFooterHeight;
		[Export("bubbleFooterHeight")]
		nfloat BubbleFooterHeight { get; set; }

		// @property (assign, nonatomic) CGFloat bubbleFooterLeft;
		[Export("bubbleFooterLeft")]
		nfloat BubbleFooterLeft { get; set; }

		// @property (assign, nonatomic) CGFloat bubbleFooterRight;
		[Export("bubbleFooterRight")]
		nfloat BubbleFooterRight { get; set; }

		// @property (nonatomic, strong) UIColor * bubbleFooterColor;
		[Export("bubbleFooterColor", ArgumentSemantic.Strong)]
		UIColor BubbleFooterColor { get; set; }

		// @property (nonatomic, strong) UIFont * bubbleFooterFont;
		[Export("bubbleFooterFont", ArgumentSemantic.Strong)]
		UIFont BubbleFooterFont { get; set; }

		// @property (assign, nonatomic) CGFloat avatarDiameter;
		[Export("avatarDiameter")]
		nfloat AvatarDiameter { get; set; }

		// @property (assign, nonatomic) CGFloat avatarMarginLeft;
		[Export("avatarMarginLeft")]
		nfloat AvatarMarginLeft { get; set; }

		// @property (assign, nonatomic) CGFloat avatarMarginRight;
		[Export("avatarMarginRight")]
		nfloat AvatarMarginRight { get; set; }

		// @property (nonatomic, strong) UIColor * avatarBackColor;
		[Export("avatarBackColor", ArgumentSemantic.Strong)]
		UIColor AvatarBackColor { get; set; }

		// @property (nonatomic, strong) UIColor * avatarTextColor;
		[Export("avatarTextColor", ArgumentSemantic.Strong)]
		UIColor AvatarTextColor { get; set; }

		// @property (nonatomic, strong) UIFont * avatarFont;
		[Export("avatarFont", ArgumentSemantic.Strong)]
		UIFont AvatarFont { get; set; }

		// @property (assign, nonatomic) CGFloat statusBubbleRadius;
		[Export("statusBubbleRadius")]
		nfloat StatusBubbleRadius { get; set; }

		// @property (nonatomic, strong) UIColor * statusBubbleColor;
		[Export("statusBubbleColor", ArgumentSemantic.Strong)]
		UIColor StatusBubbleColor { get; set; }

		// @property (nonatomic, strong) UIColor * statusTextColor;
		[Export("statusTextColor", ArgumentSemantic.Strong)]
		UIColor StatusTextColor { get; set; }

		// @property (nonatomic, strong) UIFont * statusFont;
		[Export("statusFont", ArgumentSemantic.Strong)]
		UIFont StatusFont { get; set; }

		// @property (assign, nonatomic) CGFloat statusInsetLeft;
		[Export("statusInsetLeft")]
		nfloat StatusInsetLeft { get; set; }

		// @property (assign, nonatomic) CGFloat statusInsetRight;
		[Export("statusInsetRight")]
		nfloat StatusInsetRight { get; set; }

		// @property (assign, nonatomic) CGFloat statusInsetTop;
		[Export("statusInsetTop")]
		nfloat StatusInsetTop { get; set; }

		// @property (assign, nonatomic) CGFloat statusInsetBottom;
		[Export("statusInsetBottom")]
		nfloat StatusInsetBottom { get; set; }

		// @property (assign, nonatomic) UIEdgeInsets statusInset;
		[Export("statusInset", ArgumentSemantic.Assign)]
		UIEdgeInsets StatusInset { get; set; }

		// @property (assign, nonatomic) CGFloat textBubbleWidthMin;
		[Export("textBubbleWidthMin")]
		nfloat TextBubbleWidthMin { get; set; }

		// @property (assign, nonatomic) CGFloat textBubbleHeightMin;
		[Export("textBubbleHeightMin")]
		nfloat TextBubbleHeightMin { get; set; }

		// @property (nonatomic, strong) UIColor * textBubbleColorOutgoing;
		[Export("textBubbleColorOutgoing", ArgumentSemantic.Strong)]
		UIColor TextBubbleColorOutgoing { get; set; }

		// @property (nonatomic, strong) UIColor * textBubbleColorIncoming;
		[Export("textBubbleColorIncoming", ArgumentSemantic.Strong)]
		UIColor TextBubbleColorIncoming { get; set; }

		// @property (nonatomic, strong) UIColor * textTextColorOutgoing;
		[Export("textTextColorOutgoing", ArgumentSemantic.Strong)]
		UIColor TextTextColorOutgoing { get; set; }

		// @property (nonatomic, strong) UIColor * textTextColorIncoming;
		[Export("textTextColorIncoming", ArgumentSemantic.Strong)]
		UIColor TextTextColorIncoming { get; set; }

		// @property (nonatomic, strong) UIFont * textFont;
		[Export("textFont", ArgumentSemantic.Strong)]
		UIFont TextFont { get; set; }

		// @property (assign, nonatomic) CGFloat textInsetLeft;
		[Export("textInsetLeft")]
		nfloat TextInsetLeft { get; set; }

		// @property (assign, nonatomic) CGFloat textInsetRight;
		[Export("textInsetRight")]
		nfloat TextInsetRight { get; set; }

		// @property (assign, nonatomic) CGFloat textInsetTop;
		[Export("textInsetTop")]
		nfloat TextInsetTop { get; set; }

		// @property (assign, nonatomic) CGFloat textInsetBottom;
		[Export("textInsetBottom")]
		nfloat TextInsetBottom { get; set; }

		// @property (assign, nonatomic) UIEdgeInsets textInset;
		[Export("textInset", ArgumentSemantic.Assign)]
		UIEdgeInsets TextInset { get; set; }

		// @property (assign, nonatomic) CGFloat emojiBubbleWidthMin;
		[Export("emojiBubbleWidthMin")]
		nfloat EmojiBubbleWidthMin { get; set; }

		// @property (assign, nonatomic) CGFloat emojiBubbleHeightMin;
		[Export("emojiBubbleHeightMin")]
		nfloat EmojiBubbleHeightMin { get; set; }

		// @property (nonatomic, strong) UIColor * emojiBubbleColorOutgoing;
		[Export("emojiBubbleColorOutgoing", ArgumentSemantic.Strong)]
		UIColor EmojiBubbleColorOutgoing { get; set; }

		// @property (nonatomic, strong) UIColor * emojiBubbleColorIncoming;
		[Export("emojiBubbleColorIncoming", ArgumentSemantic.Strong)]
		UIColor EmojiBubbleColorIncoming { get; set; }

		// @property (nonatomic, strong) UIFont * emojiFont;
		[Export("emojiFont", ArgumentSemantic.Strong)]
		UIFont EmojiFont { get; set; }

		// @property (assign, nonatomic) CGFloat emojiInsetLeft;
		[Export("emojiInsetLeft")]
		nfloat EmojiInsetLeft { get; set; }

		// @property (assign, nonatomic) CGFloat emojiInsetRight;
		[Export("emojiInsetRight")]
		nfloat EmojiInsetRight { get; set; }

		// @property (assign, nonatomic) CGFloat emojiInsetTop;
		[Export("emojiInsetTop")]
		nfloat EmojiInsetTop { get; set; }

		// @property (assign, nonatomic) CGFloat emojiInsetBottom;
		[Export("emojiInsetBottom")]
		nfloat EmojiInsetBottom { get; set; }

		// @property (assign, nonatomic) UIEdgeInsets emojiInset;
		[Export("emojiInset", ArgumentSemantic.Assign)]
		UIEdgeInsets EmojiInset { get; set; }

		// @property (assign, nonatomic) CGFloat pictureBubbleWidth;
		[Export("pictureBubbleWidth")]
		nfloat PictureBubbleWidth { get; set; }

		// @property (nonatomic, strong) UIColor * pictureBubbleColorOutgoing;
		[Export("pictureBubbleColorOutgoing", ArgumentSemantic.Strong)]
		UIColor PictureBubbleColorOutgoing { get; set; }

		// @property (nonatomic, strong) UIColor * pictureBubbleColorIncoming;
		[Export("pictureBubbleColorIncoming", ArgumentSemantic.Strong)]
		UIColor PictureBubbleColorIncoming { get; set; }

		// @property (nonatomic, strong) UIImage * pictureImageManual;
		[Export("pictureImageManual", ArgumentSemantic.Strong)]
		UIImage PictureImageManual { get; set; }

		// @property (assign, nonatomic) CGFloat videoBubbleWidth;
		[Export("videoBubbleWidth")]
		nfloat VideoBubbleWidth { get; set; }

		// @property (assign, nonatomic) CGFloat videoBubbleHeight;
		[Export("videoBubbleHeight")]
		nfloat VideoBubbleHeight { get; set; }

		// @property (nonatomic, strong) UIColor * videoBubbleColorOutgoing;
		[Export("videoBubbleColorOutgoing", ArgumentSemantic.Strong)]
		UIColor VideoBubbleColorOutgoing { get; set; }

		// @property (nonatomic, strong) UIColor * videoBubbleColorIncoming;
		[Export("videoBubbleColorIncoming", ArgumentSemantic.Strong)]
		UIColor VideoBubbleColorIncoming { get; set; }

		// @property (nonatomic, strong) UIImage * videoImagePlay;
		[Export("videoImagePlay", ArgumentSemantic.Strong)]
		UIImage VideoImagePlay { get; set; }

		// @property (nonatomic, strong) UIImage * videoImageManual;
		[Export("videoImageManual", ArgumentSemantic.Strong)]
		UIImage VideoImageManual { get; set; }

		// @property (assign, nonatomic) CGFloat audioBubbleWidht;
		[Export("audioBubbleWidht")]
		nfloat AudioBubbleWidht { get; set; }

		// @property (assign, nonatomic) CGFloat audioBubbleHeight;
		[Export("audioBubbleHeight")]
		nfloat AudioBubbleHeight { get; set; }

		// @property (nonatomic, strong) UIColor * audioBubbleColorOutgoing;
		[Export("audioBubbleColorOutgoing", ArgumentSemantic.Strong)]
		UIColor AudioBubbleColorOutgoing { get; set; }

		// @property (nonatomic, strong) UIColor * audioBubbleColorIncoming;
		[Export("audioBubbleColorIncoming", ArgumentSemantic.Strong)]
		UIColor AudioBubbleColorIncoming { get; set; }

		// @property (nonatomic, strong) UIColor * audioTextColorOutgoing;
		[Export("audioTextColorOutgoing", ArgumentSemantic.Strong)]
		UIColor AudioTextColorOutgoing { get; set; }

		// @property (nonatomic, strong) UIColor * audioTextColorIncoming;
		[Export("audioTextColorIncoming", ArgumentSemantic.Strong)]
		UIColor AudioTextColorIncoming { get; set; }

		// @property (nonatomic, strong) UIImage * audioImagePlay;
		[Export("audioImagePlay", ArgumentSemantic.Strong)]
		UIImage AudioImagePlay { get; set; }

		// @property (nonatomic, strong) UIImage * audioImagePause;
		[Export("audioImagePause", ArgumentSemantic.Strong)]
		UIImage AudioImagePause { get; set; }

		// @property (nonatomic, strong) UIImage * audioImageManual;
		[Export("audioImageManual", ArgumentSemantic.Strong)]
		UIImage AudioImageManual { get; set; }

		// @property (nonatomic, strong) UIFont * audioFont;
		[Export("audioFont", ArgumentSemantic.Strong)]
		UIFont AudioFont { get; set; }

		// @property (assign, nonatomic) CGFloat locationBubbleWidth;
		[Export("locationBubbleWidth")]
		nfloat LocationBubbleWidth { get; set; }

		// @property (assign, nonatomic) CGFloat locationBubbleHeight;
		[Export("locationBubbleHeight")]
		nfloat LocationBubbleHeight { get; set; }

		// @property (nonatomic, strong) UIColor * locationBubbleColorOutgoing;
		[Export("locationBubbleColorOutgoing", ArgumentSemantic.Strong)]
		UIColor LocationBubbleColorOutgoing { get; set; }

		// @property (nonatomic, strong) UIColor * locationBubbleColorIncoming;
		[Export("locationBubbleColorIncoming", ArgumentSemantic.Strong)]
		UIColor LocationBubbleColorIncoming { get; set; }

		// @property (nonatomic, strong) UIColor * inputViewBackColor;
		[Export("inputViewBackColor", ArgumentSemantic.Strong)]
		UIColor InputViewBackColor { get; set; }

		// @property (nonatomic, strong) UIColor * inputTextBackColor;
		[Export("inputTextBackColor", ArgumentSemantic.Strong)]
		UIColor InputTextBackColor { get; set; }

		// @property (nonatomic, strong) UIColor * inputTextTextColor;
		[Export("inputTextTextColor", ArgumentSemantic.Strong)]
		UIColor InputTextTextColor { get; set; }

		// @property (nonatomic, strong) UIFont * inputFont;
		[Export("inputFont", ArgumentSemantic.Strong)]
		UIFont InputFont { get; set; }

		// @property (assign, nonatomic) CGFloat inputViewHeightMin;
		[Export("inputViewHeightMin")]
		nfloat InputViewHeightMin { get; set; }

		// @property (assign, nonatomic) CGFloat inputTextHeightMin;
		[Export("inputTextHeightMin")]
		nfloat InputTextHeightMin { get; set; }

		// @property (assign, nonatomic) CGFloat inputTextHeightMax;
		[Export("inputTextHeightMax")]
		nfloat InputTextHeightMax { get; set; }

		// @property (assign, nonatomic) CGFloat inputBorderWidth;
		[Export("inputBorderWidth")]
		nfloat InputBorderWidth { get; set; }

		// @property (assign, nonatomic) CGColorRef inputBorderColor;
		[Export("inputBorderColor", ArgumentSemantic.Assign)]
		//unsafe CGColorRef* InputBorderColor { get; set; }
        NSObject InputBorderColor { get; set; }

		// @property (assign, nonatomic) CGFloat inputRadius;
		[Export("inputRadius")]
		nfloat InputRadius { get; set; }

		// @property (assign, nonatomic) CGFloat inputInsetLeft;
		[Export("inputInsetLeft")]
		nfloat InputInsetLeft { get; set; }

		// @property (assign, nonatomic) CGFloat inputInsetRight;
		[Export("inputInsetRight")]
		nfloat InputInsetRight { get; set; }

		// @property (assign, nonatomic) CGFloat inputInsetTop;
		[Export("inputInsetTop")]
		nfloat InputInsetTop { get; set; }

		// @property (assign, nonatomic) CGFloat inputInsetBottom;
		[Export("inputInsetBottom")]
		nfloat InputInsetBottom { get; set; }

		// @property (assign, nonatomic) UIEdgeInsets inputInset;
		[Export("inputInset", ArgumentSemantic.Assign)]
		UIEdgeInsets InputInset { get; set; }

		// +(RCMessages *)shared;
		[Static]
		[Export("shared")]
		//[Verify(MethodToProperty)]
		RCMessages Shared { get; }

        // +(CGFloat)sectionHeaderMargin;
        [Static]
        [Export("sectionHeaderMargin")]
        //[Verify(MethodToProperty)]
        nfloat GetSectionHeaderMargin();

        // +(CGFloat)sectionHeaderHeight;
        [Static]
        [Export("sectionHeaderHeight")]
        //[Verify(MethodToProperty)]
        nfloat GetSectionHeaderHeight();

		// +(CGFloat)sectionHeaderLeft;
		[Static]
		[Export("sectionHeaderLeft")]
		//[Verify(MethodToProperty)]
		nfloat GetSectionHeaderLeft();

		// +(CGFloat)sectionHeaderRight;
		[Static]
		[Export("sectionHeaderRight")]
		//[Verify(MethodToProperty)]
		nfloat GetSectionHeaderRight();

		// +(UIColor *)sectionHeaderColor;
		[Static]
		[Export("sectionHeaderColor")]
		//[Verify(MethodToProperty)]
		UIColor GetSectionHeaderColor();

		// +(UIFont *)sectionHeaderFont;
		[Static]
		[Export("sectionHeaderFont")]
		//[Verify(MethodToProperty)]
		UIFont GetSectionHeaderFont();

		// +(CGFloat)sectionFooterHeight;
		[Static]
		[Export("sectionFooterHeight")]
		//[Verify(MethodToProperty)]
		nfloat GetSectionFooterHeight();

		// +(CGFloat)sectionFooterLeft;
		[Static]
		[Export("sectionFooterLeft")]
		//[Verify(MethodToProperty)]
		nfloat GetSectionFooterLeft();

		// +(CGFloat)sectionFooterRight;
		[Static]
		[Export("sectionFooterRight")]
		//[Verify(MethodToProperty)]
		nfloat GetSectionFooterRight();

		// +(UIColor *)sectionFooterColor;
		[Static]
		[Export("sectionFooterColor")]
		//[Verify(MethodToProperty)]
		UIColor GetSectionFooterColor();

		// +(UIFont *)sectionFooterFont;
		[Static]
		[Export("sectionFooterFont")]
		//[Verify(MethodToProperty)]
		UIFont GetSectionFooterFont();

		// +(CGFloat)sectionFooterMargin;
		[Static]
		[Export("sectionFooterMargin")]
		//[Verify(MethodToProperty)]
		nfloat GetSectionFooterMargin();

		// +(CGFloat)bubbleHeaderHeight;
		[Static]
		[Export("bubbleHeaderHeight")]
		//[Verify(MethodToProperty)]
		nfloat GetBubbleHeaderHeight();

		// +(CGFloat)bubbleHeaderLeft;
		[Static]
		[Export("bubbleHeaderLeft")]
		//[Verify(MethodToProperty)]
		nfloat GetBubbleHeaderLeft();

		// +(CGFloat)bubbleHeaderRight;
		[Static]
		[Export("bubbleHeaderRight")]
		//[Verify(MethodToProperty)]
		nfloat GetBubbleHeaderRight();

		// +(UIColor *)bubbleHeaderColor;
		[Static]
		[Export("bubbleHeaderColor")]
		//[Verify(MethodToProperty)]
		UIColor GetBubbleHeaderColor();

		// +(UIFont *)bubbleHeaderFont;
		[Static]
		[Export("bubbleHeaderFont")]
		//[Verify(MethodToProperty)]
		UIFont GetBubbleHeaderFont();

		// +(CGFloat)bubbleMarginLeft;
		[Static]
		[Export("bubbleMarginLeft")]
		//[Verify(MethodToProperty)]
		nfloat GetBubbleMarginLeft();

		// +(CGFloat)bubbleMarginRight;
		[Static]
		[Export("bubbleMarginRight")]
		//[Verify(MethodToProperty)]
		nfloat GetBubbleMarginRight();

		// +(CGFloat)bubbleRadius;
		[Static]
		[Export("bubbleRadius")]
		//[Verify(MethodToProperty)]
		nfloat GetBubbleRadius();

		// +(CGFloat)bubbleFooterHeight;
		[Static]
		[Export("bubbleFooterHeight")]
		//[Verify(MethodToProperty)]
		nfloat GetBubbleFooterHeight();

		// +(CGFloat)bubbleFooterLeft;
		[Static]
		[Export("bubbleFooterLeft")]
		//[Verify(MethodToProperty)]
		nfloat GetBubbleFooterLeft();

		// +(CGFloat)bubbleFooterRight;
		[Static]
		[Export("bubbleFooterRight")]
		//[Verify(MethodToProperty)]
		nfloat GetBubbleFooterRight();

		// +(UIColor *)bubbleFooterColor;
		[Static]
		[Export("bubbleFooterColor")]
		//[Verify(MethodToProperty)]
		UIColor GetBubbleFooterColor();

		// +(UIFont *)bubbleFooterFont;
		[Static]
		[Export("bubbleFooterFont")]
		//[Verify(MethodToProperty)]
		UIFont GetBubbleFooterFont();

		// +(CGFloat)avatarDiameter;
		[Static]
		[Export("avatarDiameter")]
		//[Verify(MethodToProperty)]
		nfloat GetAvatarDiameter();

		// +(CGFloat)avatarMarginLeft;
		[Static]
		[Export("avatarMarginLeft")]
		//[Verify(MethodToProperty)]
		nfloat GetAvatarMarginLeft();

		// +(CGFloat)avatarMarginRight;
		[Static]
		[Export("avatarMarginRight")]
		//[Verify(MethodToProperty)]
		nfloat GetAvatarMarginRight();

		// +(UIColor *)avatarBackColor;
		[Static]
		[Export("avatarBackColor")]
		//[Verify(MethodToProperty)]
		UIColor GetAvatarBackColor();

		// +(UIColor *)avatarTextColor;
		[Static]
		[Export("avatarTextColor")]
		//[Verify(MethodToProperty)]
		UIColor GetAvatarTextColor();

		// +(UIFont *)avatarFont;
		[Static]
		[Export("avatarFont")]
		//[Verify(MethodToProperty)]
		UIFont GetAvatarFont();

		// +(CGFloat)statusBubbleRadius;
		[Static]
		[Export("statusBubbleRadius")]
		//[Verify(MethodToProperty)]
		nfloat GetStatusBubbleRadius();

		// +(UIColor *)statusBubbleColor;
		[Static]
		[Export("statusBubbleColor")]
		//[Verify(MethodToProperty)]
		UIColor GetStatusBubbleColor();

		// +(UIColor *)statusTextColor;
		[Static]
		[Export("statusTextColor")]
		//[Verify(MethodToProperty)]
		UIColor GetStatusTextColor();

		// +(UIFont *)statusFont;
		[Static]
		[Export("statusFont")]
		//[Verify(MethodToProperty)]
		UIFont GetStatusFont();

		// +(CGFloat)statusInsetLeft;
		[Static]
		[Export("statusInsetLeft")]
		//[Verify(MethodToProperty)]
		nfloat GetStatusInsetLeft();

		// +(CGFloat)statusInsetRight;
		[Static]
		[Export("statusInsetRight")]
		//[Verify(MethodToProperty)]
		nfloat GetStatusInsetRight();

		// +(CGFloat)statusInsetTop;
		[Static]
		[Export("statusInsetTop")]
		//[Verify(MethodToProperty)]
		nfloat GetStatusInsetTop();

		// +(CGFloat)statusInsetBottom;
		[Static]
		[Export("statusInsetBottom")]
		//[Verify(MethodToProperty)]
		nfloat GetStatusInsetBottom();

		// +(UIEdgeInsets)statusInset;
		[Static]
		[Export("statusInset")]
		//[Verify(MethodToProperty)]
		UIEdgeInsets GetStatusInset();

		// +(CGFloat)textBubbleWidthMin;
		[Static]
		[Export("textBubbleWidthMin")]
		//[Verify(MethodToProperty)]
		nfloat GetTextBubbleWidthMin();

		// +(CGFloat)textBubbleHeightMin;
		[Static]
		[Export("textBubbleHeightMin")]
		//[Verify(MethodToProperty)]
		nfloat GetTextBubbleHeightMin();

		// +(UIColor *)textBubbleColorOutgoing;
		[Static]
		[Export("textBubbleColorOutgoing")]
		//[Verify(MethodToProperty)]
		UIColor GetTextBubbleColorOutgoing();

		// +(UIColor *)textBubbleColorIncoming;
		[Static]
		[Export("textBubbleColorIncoming")]
		//[Verify(MethodToProperty)]
		UIColor GetTextBubbleColorIncoming();

		// +(UIColor *)textTextColorOutgoing;
		[Static]
		[Export("textTextColorOutgoing")]
		//[Verify(MethodToProperty)]
		UIColor GetTextTextColorOutgoing();

		// +(UIColor *)textTextColorIncoming;
		[Static]
		[Export("textTextColorIncoming")]
		//[Verify(MethodToProperty)]
		UIColor GetTextTextColorIncoming();

		// +(UIFont *)textFont;
		[Static]
		[Export("textFont")]
		//[Verify(MethodToProperty)]
		UIFont GetTextFont();

		// +(CGFloat)textInsetLeft;
		[Static]
		[Export("textInsetLeft")]
		//[Verify(MethodToProperty)]
		nfloat GetTextInsetLeft();

		// +(CGFloat)textInsetRight;
		[Static]
		[Export("textInsetRight")]
		//[Verify(MethodToProperty)]
		nfloat GetTextInsetRight();

		// +(CGFloat)textInsetTop;
		[Static]
		[Export("textInsetTop")]
		//[Verify(MethodToProperty)]
		nfloat GetTextInsetTop();

		// +(CGFloat)textInsetBottom;
		[Static]
		[Export("textInsetBottom")]
		//[Verify(MethodToProperty)]
		nfloat GetTextInsetBottom();

		// +(UIEdgeInsets)textInset;
		[Static]
		[Export("textInset")]
		//[Verify(MethodToProperty)]
		UIEdgeInsets GetTextInset();

		// +(CGFloat)emojiBubbleWidthMin;
		[Static]
		[Export("emojiBubbleWidthMin")]
		//[Verify(MethodToProperty)]
		nfloat GetEmojiBubbleWidthMin();

		// +(CGFloat)emojiBubbleHeightMin;
		[Static]
		[Export("emojiBubbleHeightMin")]
		//[Verify(MethodToProperty)]
		nfloat GetEmojiBubbleHeightMin();

		// +(UIColor *)emojiBubbleColorOutgoing;
		[Static]
		[Export("emojiBubbleColorOutgoing")]
		//[Verify(MethodToProperty)]
		UIColor GetEmojiBubbleColorOutgoing();

		// +(UIColor *)emojiBubbleColorIncoming;
		[Static]
		[Export("emojiBubbleColorIncoming")]
		//[Verify(MethodToProperty)]
		UIColor GetEmojiBubbleColorIncoming();

		// +(UIFont *)emojiFont;
		[Static]
		[Export("emojiFont")]
		//[Verify(MethodToProperty)]
		UIFont GetEmojiFont();

		// +(CGFloat)emojiInsetLeft;
		[Static]
		[Export("emojiInsetLeft")]
		//[Verify(MethodToProperty)]
		nfloat GetEmojiInsetLeft();

		// +(CGFloat)emojiInsetRight;
		[Static]
		[Export("emojiInsetRight")]
		//[Verify(MethodToProperty)]
		nfloat GetEmojiInsetRight();

		// +(CGFloat)emojiInsetTop;
		[Static]
		[Export("emojiInsetTop")]
		//[Verify(MethodToProperty)]
		nfloat GetEmojiInsetTop();

		// +(CGFloat)emojiInsetBottom;
		[Static]
		[Export("emojiInsetBottom")]
		//[Verify(MethodToProperty)]
		nfloat GetEmojiInsetBottom();

		// +(UIEdgeInsets)emojiInset;
		[Static]
		[Export("emojiInset")]
		//[Verify(MethodToProperty)]
		UIEdgeInsets GetEmojiInset();

		// +(CGFloat)pictureBubbleWidth;
		[Static]
		[Export("pictureBubbleWidth")]
		//[Verify(MethodToProperty)]
		nfloat GetPictureBubbleWidth();

		// +(UIColor *)pictureBubbleColorOutgoing;
		[Static]
		[Export("pictureBubbleColorOutgoing")]
		//[Verify(MethodToProperty)]
		UIColor GetPictureBubbleColorOutgoing();

		// +(UIColor *)pictureBubbleColorIncoming;
		[Static]
		[Export("pictureBubbleColorIncoming")]
		//[Verify(MethodToProperty)]
		UIColor GetPictureBubbleColorIncoming();

		// +(UIImage *)pictureImageManual;
		[Static]
		[Export("pictureImageManual")]
		//[Verify(MethodToProperty)]
		UIImage GetPictureImageManual();

		// +(CGFloat)videoBubbleWidth;
		[Static]
		[Export("videoBubbleWidth")]
		//[Verify(MethodToProperty)]
		nfloat GetVideoBubbleWidth();

		// +(CGFloat)videoBubbleHeight;
		[Static]
		[Export("videoBubbleHeight")]
		//[Verify(MethodToProperty)]
		nfloat GetVideoBubbleHeight();

		// +(UIColor *)videoBubbleColorOutgoing;
		[Static]
		[Export("videoBubbleColorOutgoing")]
		//[Verify(MethodToProperty)]
		UIColor GetVideoBubbleColorOutgoing();

		// +(UIColor *)videoBubbleColorIncoming;
		[Static]
		[Export("videoBubbleColorIncoming")]
		//[Verify(MethodToProperty)]
		UIColor GetVideoBubbleColorIncoming();

		// +(UIImage *)videoImagePlay;
		[Static]
		[Export("videoImagePlay")]
		//[Verify(MethodToProperty)]
		UIImage GetVideoImagePlay();

		// +(UIImage *)videoImageManual;
		[Static]
		[Export("videoImageManual")]
		//[Verify(MethodToProperty)]
		UIImage GetVideoImageManual();

		// +(CGFloat)audioBubbleWidht;
		[Static]
		[Export("audioBubbleWidht")]
		//[Verify(MethodToProperty)]
		nfloat GetAudioBubbleWidht();

		// +(CGFloat)audioBubbleHeight;
		[Static]
		[Export("audioBubbleHeight")]
		//[Verify(MethodToProperty)]
		nfloat GetAudioBubbleHeight();

		// +(UIColor *)audioBubbleColorOutgoing;
		[Static]
		[Export("audioBubbleColorOutgoing")]
		//[Verify(MethodToProperty)]
		UIColor GetAudioBubbleColorOutgoing();

		// +(UIColor *)audioBubbleColorIncoming;
		[Static]
		[Export("audioBubbleColorIncoming")]
		//[Verify(MethodToProperty)]
		UIColor GetAudioBubbleColorIncoming();

		// +(UIColor *)audioTextColorOutgoing;
		[Static]
		[Export("audioTextColorOutgoing")]
		//[Verify(MethodToProperty)]
		UIColor GetAudioTextColorOutgoing();

		// +(UIColor *)audioTextColorIncoming;
		[Static]
		[Export("audioTextColorIncoming")]
		//[Verify(MethodToProperty)]
		UIColor GetAudioTextColorIncoming();

		// +(UIImage *)audioImagePlay;
		[Static]
		[Export("audioImagePlay")]
		//[Verify(MethodToProperty)]
		UIImage GetAudioImagePlay();

		// +(UIImage *)audioImagePause;
		[Static]
		[Export("audioImagePause")]
		//[Verify(MethodToProperty)]
		UIImage GetAudioImagePause();

		// +(UIImage *)audioImageManual;
		[Static]
		[Export("audioImageManual")]
		//[Verify(MethodToProperty)]
		UIImage GetAudioImageManual();

		// +(UIFont *)audioFont;
		[Static]
		[Export("audioFont")]
		//[Verify(MethodToProperty)]
		UIFont GetAudioFont();

		// +(CGFloat)locationBubbleWidth;
		[Static]
		[Export("locationBubbleWidth")]
		//[Verify(MethodToProperty)]
		nfloat GetLocationBubbleWidth();

		// +(CGFloat)locationBubbleHeight;
		[Static]
		[Export("locationBubbleHeight")]
		//[Verify(MethodToProperty)]
		nfloat GetLocationBubbleHeight();

		// +(UIColor *)locationBubbleColorOutgoing;
		[Static]
		[Export("locationBubbleColorOutgoing")]
		//[Verify(MethodToProperty)]
		UIColor GetLocationBubbleColorOutgoing();

		// +(UIColor *)locationBubbleColorIncoming;
		[Static]
		[Export("locationBubbleColorIncoming")]
		//[Verify(MethodToProperty)]
		UIColor GetLocationBubbleColorIncoming();

		// +(UIColor *)inputViewBackColor;
		[Static]
		[Export("inputViewBackColor")]
		//[Verify(MethodToProperty)]
		UIColor GetInputViewBackColor();

		// +(UIColor *)inputTextBackColor;
		[Static]
		[Export("inputTextBackColor")]
		//[Verify(MethodToProperty)]
		UIColor GetInputTextBackColor();

		// +(UIColor *)inputTextTextColor;
		[Static]
		[Export("inputTextTextColor")]
		//[Verify(MethodToProperty)]
		UIColor GetInputTextTextColor();

		// +(UIFont *)inputFont;
		[Static]
		[Export("inputFont")]
		//[Verify(MethodToProperty)]
		UIFont GetInputFont();

		// +(CGFloat)inputViewHeightMin;
		[Static]
		[Export("inputViewHeightMin")]
		//[Verify(MethodToProperty)]
		nfloat GetInputViewHeightMin();

		// +(CGFloat)inputTextHeightMin;
		[Static]
		[Export("inputTextHeightMin")]
		//[Verify(MethodToProperty)]
		nfloat GetInputTextHeightMin();

		// +(CGFloat)inputTextHeightMax;
		[Static]
		[Export("inputTextHeightMax")]
		//[Verify(MethodToProperty)]
		nfloat GetInputTextHeightMax();

		// +(CGFloat)inputBorderWidth;
		[Static]
		[Export("inputBorderWidth")]
		//[Verify(MethodToProperty)]
		nfloat GetInputBorderWidth();

		// +(CGColorRef)inputBorderColor;
		[Static]
		[Export("inputBorderColor")]
		//[Verify(MethodToProperty)]
		//unsafe CGColorRef* GetInputBorderColor();
        NSObject GetInputBorderColor();

		// +(CGFloat)inputRadius;
		[Static]
		[Export("inputRadius")]
		//[Verify(MethodToProperty)]
		nfloat GetInputRadius();

		// +(CGFloat)inputInsetLeft;
		[Static]
		[Export("inputInsetLeft")]
		//[Verify(MethodToProperty)]
		nfloat GetInputInsetLeft();

		// +(CGFloat)inputInsetRight;
		[Static]
		[Export("inputInsetRight")]
		//[Verify(MethodToProperty)]
		nfloat GetInputInsetRight();

		// +(CGFloat)inputInsetTop;
		[Static]
		[Export("inputInsetTop")]
		//[Verify(MethodToProperty)]
		nfloat GetInputInsetTop();

		// +(CGFloat)inputInsetBottom;
		[Static]
		[Export("inputInsetBottom")]
		//[Verify(MethodToProperty)]
		nfloat GetInputInsetBottom();

		// +(UIEdgeInsets)inputInset;
		[Static]
		[Export("inputInset")]
		//[Verify(MethodToProperty)]
		UIEdgeInsets GetInputInset();
	}

	// @interface RCMessage : NSObject
	[BaseType(typeof(NSObject))]
	interface RCMessage
	{
		// @property (assign, nonatomic) NSInteger type;
		[Export("type")]
		nint Type { get; set; }

		// @property (assign, nonatomic) BOOL incoming;
		[Export("incoming")]
		bool Incoming { get; set; }

		// @property (assign, nonatomic) BOOL outgoing;
		[Export("outgoing")]
		bool Outgoing { get; set; }

		// @property (nonatomic, strong) NSString * text;
		[Export("text", ArgumentSemantic.Strong)]
		string Text { get; set; }

		// @property (nonatomic, strong) UIImage * picture_image;
		[Export("picture_image", ArgumentSemantic.Strong)]
		UIImage Picture_image { get; set; }

		// @property (assign, nonatomic) NSInteger picture_width;
		[Export("picture_width")]
		nint Picture_width { get; set; }

		// @property (assign, nonatomic) NSInteger picture_height;
		[Export("picture_height")]
		nint Picture_height { get; set; }

		// @property (nonatomic, strong) NSString * video_path;
		[Export("video_path", ArgumentSemantic.Strong)]
		string Video_path { get; set; }

		// @property (nonatomic, strong) UIImage * video_thumbnail;
		[Export("video_thumbnail", ArgumentSemantic.Strong)]
		UIImage Video_thumbnail { get; set; }

		// @property (assign, nonatomic) NSInteger video_duration;
		[Export("video_duration")]
		nint Video_duration { get; set; }

		// @property (nonatomic, strong) NSString * audio_path;
		[Export("audio_path", ArgumentSemantic.Strong)]
		string Audio_path { get; set; }

		// @property (assign, nonatomic) NSInteger audio_duration;
		[Export("audio_duration")]
		nint Audio_duration { get; set; }

		// @property (assign, nonatomic) NSInteger audio_status;
		[Export("audio_status")]
		nint Audio_status { get; set; }

		// @property (assign, nonatomic) CLLocationDegrees latitude;
		[Export("latitude")]
		double Latitude { get; set; }

		// @property (assign, nonatomic) CLLocationDegrees longitude;
		[Export("longitude")]
		double Longitude { get; set; }

		// @property (nonatomic, strong) UIImage * location_thumbnail;
		[Export("location_thumbnail", ArgumentSemantic.Strong)]
		UIImage Location_thumbnail { get; set; }

		// @property (assign, nonatomic) NSInteger status;
		[Export("status")]
		nint Status { get; set; }

		// -(id)initWithStatus:(NSString *)text;
		[Export("initWithStatus:")]
		IntPtr Constructor(string text);

		// -(id)initWithText:(NSString *)text incoming:(BOOL)incoming;
		[Export("initWithText:incoming:")]
		IntPtr Constructor(string text, bool incoming);

		// -(id)initWithEmoji:(NSString *)text incoming:(BOOL)incoming;
		//[Export("initWithEmoji:incoming:")]
		//IntPtr Constructor(string text, bool incoming);

		// -(id)initWithPicture:(UIImage *)image width:(NSInteger)width height:(NSInteger)height incoming:(BOOL)incoming;
		[Export("initWithPicture:width:height:incoming:")]
        IntPtr Constructor([NullAllowed] UIImage image, nint width, nint height, bool incoming);

		// -(id)initWithVideo:(NSString *)path durarion:(NSInteger)duration incoming:(BOOL)incoming;
		[Export("initWithVideo:durarion:incoming:")]
		IntPtr Constructor(string path, nint duration, bool incoming);

		// -(id)initWithAudio:(NSString *)path durarion:(NSInteger)duration incoming:(BOOL)incoming;
		//[Export("initWithAudio:durarion:incoming:")]
		//IntPtr Constructor(string path, nint duration, bool incoming);

		// -(id)initWithLatitude:(CLLocationDegrees)latitude longitude:(CLLocationDegrees)longitude incoming:(BOOL)incoming completion:(void (^)(void))completion;
		[Export("initWithLatitude:longitude:incoming:completion:")]
		IntPtr Constructor(double latitude, double longitude, bool incoming, Action completion);
	}

	// @interface RCMenuItem : UIMenuItem
	[BaseType(typeof(UIMenuItem))]
	interface RCMenuItem
	{
		// @property (nonatomic, strong) NSIndexPath * indexPath;
		[Export("indexPath", ArgumentSemantic.Strong)]
		NSIndexPath IndexPath { get; set; }

		// +(NSIndexPath *)indexPath:(UIMenuController *)menuController;
		[Static]
		[Export("indexPath:")]
		NSIndexPath GetIndexPath(UIMenuController menuController);
	}

	// @interface RCMessagesView : UIViewController <UITableViewDataSource, UITableViewDelegate, UITextViewDelegate>
	[BaseType(typeof(UIViewController))]
	interface RCMessagesView : IUITableViewDataSource, IUITableViewDelegate, IUITextViewDelegate
	{
		// @property (nonatomic, strong) UIView * viewTitle __attribute__((iboutlet));
		[Export("viewTitle", ArgumentSemantic.Strong)]
		UIView ViewTitle { get; set; }

		// @property (nonatomic, strong) UILabel * labelTitle1 __attribute__((iboutlet));
		[Export("labelTitle1", ArgumentSemantic.Strong)]
		UILabel LabelTitle1 { get; set; }

		// @property (nonatomic, strong) UILabel * labelTitle2 __attribute__((iboutlet));
		[Export("labelTitle2", ArgumentSemantic.Strong)]
		UILabel LabelTitle2 { get; set; }

		// @property (nonatomic, strong) UIButton * buttonTitle __attribute__((iboutlet));
		[Export("buttonTitle", ArgumentSemantic.Strong)]
		UIButton ButtonTitle { get; set; }

		// @property (nonatomic, strong) UITableView * tableView __attribute__((iboutlet));
		[Export("tableView", ArgumentSemantic.Strong)]
		UITableView TableView { get; set; }

		// @property (nonatomic, strong) UIView * viewLoadEarlier __attribute__((iboutlet));
		[Export("viewLoadEarlier", ArgumentSemantic.Strong)]
		UIView ViewLoadEarlier { get; set; }

		// @property (nonatomic, strong) UIView * viewTypingIndicator __attribute__((iboutlet));
		[Export("viewTypingIndicator", ArgumentSemantic.Strong)]
		UIView ViewTypingIndicator { get; set; }

		// @property (nonatomic, strong) UIView * viewInput __attribute__((iboutlet));
		[Export("viewInput", ArgumentSemantic.Strong)]
		UIView ViewInput { get; set; }

		// @property (nonatomic, strong) UIButton * buttonInputAttach __attribute__((iboutlet));
		[Export("buttonInputAttach", ArgumentSemantic.Strong)]
		UIButton ButtonInputAttach { get; set; }

		// @property (nonatomic, strong) UIButton * buttonInputAudio __attribute__((iboutlet));
		[Export("buttonInputAudio", ArgumentSemantic.Strong)]
		UIButton ButtonInputAudio { get; set; }

		// @property (nonatomic, strong) UIButton * buttonInputSend __attribute__((iboutlet));
		[Export("buttonInputSend", ArgumentSemantic.Strong)]
		UIButton ButtonInputSend { get; set; }

		// @property (nonatomic, strong) UITextView * textInput __attribute__((iboutlet));
		[Export("textInput", ArgumentSemantic.Strong)]
		UITextView TextInput { get; set; }

		// @property (nonatomic, strong) UIView * viewInputAudio __attribute__((iboutlet));
		[Export("viewInputAudio", ArgumentSemantic.Strong)]
		UIView ViewInputAudio { get; set; }

		// @property (nonatomic, strong) UILabel * labelInputAudio __attribute__((iboutlet));
		[Export("labelInputAudio", ArgumentSemantic.Strong)]
		UILabel LabelInputAudio { get; set; }

		// -(void)loadEarlierShow:(BOOL)show;
		[Export("loadEarlierShow:")]
		void LoadEarlierShow(bool show);

		// -(RCMessage *)rcmessage:(NSIndexPath *)indexPath;
		[Export("rcmessage:")]
		RCMessage Rcmessage(NSIndexPath indexPath);

		// -(NSString *)avatarInitials:(NSIndexPath *)indexPath;
		[Export("avatarInitials:")]
		string AvatarInitials(NSIndexPath indexPath);

		// -(UIImage *)avatarImage:(NSIndexPath *)indexPath;
		[Export("avatarImage:")]
		UIImage AvatarImage(NSIndexPath indexPath);

		// -(NSString *)textSectionHeader:(NSIndexPath *)indexPath;
		[Export("textSectionHeader:")]
		string TextSectionHeader(NSIndexPath indexPath);

		// -(NSString *)textBubbleHeader:(NSIndexPath *)indexPath;
		[Export("textBubbleHeader:")]
		string TextBubbleHeader(NSIndexPath indexPath);

		// -(NSString *)textBubbleFooter:(NSIndexPath *)indexPath;
		[Export("textBubbleFooter:")]
		string TextBubbleFooter(NSIndexPath indexPath);

		// -(NSString *)textSectionFooter:(NSIndexPath *)indexPath;
		[Export("textSectionFooter:")]
		string TextSectionFooter(NSIndexPath indexPath);

		// -(NSArray *)menuItems:(NSIndexPath *)indexPath;
		[Export("menuItems:")]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] MenuItems(NSIndexPath indexPath);

		// -(void)typingIndicatorShow:(BOOL)show animated:(BOOL)animated;
		[Export("typingIndicatorShow:animated:")]
		void TypingIndicatorShow(bool show, bool animated);

		// -(void)actionTapBubble:(NSIndexPath *)indexPath;
		[Export("actionTapBubble:")]
		void ActionTapBubble(NSIndexPath indexPath);

		// -(void)actionTapAvatar:(NSIndexPath *)indexPath;
		[Export("actionTapAvatar:")]
		void ActionTapAvatar(NSIndexPath indexPath);

		// -(void)scrollToBottom:(BOOL)animated;
		[Export("scrollToBottom:")]
		void ScrollToBottom(bool animated);
	}

	// @interface RCMessageCell : UITableViewCell
	[BaseType(typeof(UITableViewCell))]
	interface RCMessageCell
	{
		// @property (nonatomic, strong) UIView * viewBubble;
		[Export("viewBubble", ArgumentSemantic.Strong)]
		UIView ViewBubble { get; set; }

		// @property (nonatomic, strong) UIImageView * imageAvatar;
		[Export("imageAvatar", ArgumentSemantic.Strong)]
		UIImageView ImageAvatar { get; set; }

		// @property (nonatomic, strong) UILabel * labelAvatar;
		[Export("labelAvatar", ArgumentSemantic.Strong)]
		UILabel LabelAvatar { get; set; }

		// -(void)bindData:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Export("bindData:messagesView:")]
		void BindData(NSIndexPath indexPath, RCMessagesView messagesView);

		// -(void)layoutSubviews:(CGSize)size;
		[Export("layoutSubviews:")]
		void LayoutSubviews(CGSize size);
	}

	// @interface RCAudioMessageCell : RCMessageCell
	[BaseType(typeof(RCMessageCell))]
	interface RCAudioMessageCell
	{
		// @property (nonatomic, strong) UIImageView * imageStatus;
		[Export("imageStatus", ArgumentSemantic.Strong)]
		UIImageView ImageStatus { get; set; }

		// @property (nonatomic, strong) UILabel * labelDuration;
		[Export("labelDuration", ArgumentSemantic.Strong)]
		UILabel LabelDuration { get; set; }

		// @property (nonatomic, strong) UIImageView * imageManual;
		[Export("imageManual", ArgumentSemantic.Strong)]
		UIImageView ImageManual { get; set; }

		// @property (nonatomic, strong) UIActivityIndicatorView * spinner;
		[Export("spinner", ArgumentSemantic.Strong)]
		UIActivityIndicatorView Spinner { get; set; }

		// -(void)bindData:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Export("bindData:messagesView:")]
		void BindData(NSIndexPath indexPath, RCMessagesView messagesView);

		// +(CGFloat)height:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Static]
		[Export("height:messagesView:")]
		nfloat Height(NSIndexPath indexPath, RCMessagesView messagesView);
	}

	// @interface RCBubbleFooterCell : UITableViewCell
	[BaseType(typeof(UITableViewCell))]
	interface RCBubbleFooterCell
	{
		// @property (nonatomic, strong) UILabel * labelBubbleFooter;
		[Export("labelBubbleFooter", ArgumentSemantic.Strong)]
		UILabel LabelBubbleFooter { get; set; }

		// -(void)bindData:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Export("bindData:messagesView:")]
		void BindData(NSIndexPath indexPath, RCMessagesView messagesView);

		// +(CGFloat)height:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Static]
		[Export("height:messagesView:")]
		nfloat Height(NSIndexPath indexPath, RCMessagesView messagesView);
	}

	// @interface RCBubbleHeaderCell : UITableViewCell
	[BaseType(typeof(UITableViewCell))]
	interface RCBubbleHeaderCell
	{
		// @property (nonatomic, strong) UILabel * labelBubbleHeader;
		[Export("labelBubbleHeader", ArgumentSemantic.Strong)]
		UILabel LabelBubbleHeader { get; set; }

		// -(void)bindData:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Export("bindData:messagesView:")]
		void BindData(NSIndexPath indexPath, RCMessagesView messagesView);

		// +(CGFloat)height:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Static]
		[Export("height:messagesView:")]
		nfloat Height(NSIndexPath indexPath, RCMessagesView messagesView);
	}

	// @interface RCEmojiMessageCell : RCMessageCell
	[BaseType(typeof(RCMessageCell))]
	interface RCEmojiMessageCell
	{
		// @property (nonatomic, strong) UITextView * textView;
		[Export("textView", ArgumentSemantic.Strong)]
		UITextView TextView { get; set; }

		// -(void)bindData:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Export("bindData:messagesView:")]
		void BindData(NSIndexPath indexPath, RCMessagesView messagesView);

		// +(CGFloat)height:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Static]
		[Export("height:messagesView:")]
		nfloat Height(NSIndexPath indexPath, RCMessagesView messagesView);
	}

	// @interface RCLocationMessageCell : RCMessageCell
	[BaseType(typeof(RCMessageCell))]
	interface RCLocationMessageCell
	{
		// @property (nonatomic, strong) UIImageView * imageView;
		[Export("imageView", ArgumentSemantic.Strong)]
		UIImageView ImageView { get; set; }

		// @property (nonatomic, strong) UIActivityIndicatorView * spinner;
		[Export("spinner", ArgumentSemantic.Strong)]
		UIActivityIndicatorView Spinner { get; set; }

		// -(void)bindData:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Export("bindData:messagesView:")]
		void BindData(NSIndexPath indexPath, RCMessagesView messagesView);

		// +(CGFloat)height:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Static]
		[Export("height:messagesView:")]
		nfloat Height(NSIndexPath indexPath, RCMessagesView messagesView);
	}

	// @interface RCSectionFooterCell : UITableViewCell
	[BaseType(typeof(UITableViewCell))]
	interface RCSectionFooterCell
	{
		// @property (nonatomic, strong) UILabel * labelSectionFooter;
		[Export("labelSectionFooter", ArgumentSemantic.Strong)]
		UILabel LabelSectionFooter { get; set; }

		// -(void)bindData:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Export("bindData:messagesView:")]
		void BindData(NSIndexPath indexPath, RCMessagesView messagesView);

		// +(CGFloat)height:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Static]
		[Export("height:messagesView:")]
		nfloat Height(NSIndexPath indexPath, RCMessagesView messagesView);
	}

	// @interface RCSectionHeaderCell : UITableViewCell
	[BaseType(typeof(UITableViewCell))]
	interface RCSectionHeaderCell
	{
		// @property (nonatomic, strong) UILabel * labelSectionHeader;
		[Export("labelSectionHeader", ArgumentSemantic.Strong)]
		UILabel LabelSectionHeader { get; set; }

		// -(void)bindData:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Export("bindData:messagesView:")]
		void BindData(NSIndexPath indexPath, RCMessagesView messagesView);

		// +(CGFloat)height:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Static]
		[Export("height:messagesView:")]
		nfloat Height(NSIndexPath indexPath, RCMessagesView messagesView);
	}

	// @interface RCTextMessageCell : RCMessageCell
	[BaseType(typeof(RCMessageCell))]
	interface RCTextMessageCell
	{
		// @property (nonatomic, strong) UITextView * textView;
		[Export("textView", ArgumentSemantic.Strong)]
		UITextView TextView { get; set; }

		// -(void)bindData:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Export("bindData:messagesView:")]
		void BindData(NSIndexPath indexPath, RCMessagesView messagesView);

		// +(CGFloat)height:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Static]
		[Export("height:messagesView:")]
		nfloat Height(NSIndexPath indexPath, RCMessagesView messagesView);
	}

	// @interface RCPictureMessageCell : RCMessageCell
	[BaseType(typeof(RCMessageCell))]
	interface RCPictureMessageCell
	{
		// @property (nonatomic, strong) UIImageView * imageView;
		[Export("imageView", ArgumentSemantic.Strong)]
		UIImageView ImageView { get; set; }

		// @property (nonatomic, strong) UIImageView * imageManual;
		[Export("imageManual", ArgumentSemantic.Strong)]
		UIImageView ImageManual { get; set; }

		// @property (nonatomic, strong) UIActivityIndicatorView * spinner;
		[Export("spinner", ArgumentSemantic.Strong)]
		UIActivityIndicatorView Spinner { get; set; }

		// -(void)bindData:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Export("bindData:messagesView:")]
		void BindData(NSIndexPath indexPath, RCMessagesView messagesView);

		// +(CGFloat)height:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Static]
		[Export("height:messagesView:")]
		nfloat Height(NSIndexPath indexPath, RCMessagesView messagesView);
	}

	// @interface RCVideoMessageCell : RCMessageCell
	[BaseType(typeof(RCMessageCell))]
	interface RCVideoMessageCell
	{
		// @property (nonatomic, strong) UIImageView * imageView;
		[Export("imageView", ArgumentSemantic.Strong)]
		UIImageView ImageView { get; set; }

		// @property (nonatomic, strong) UIImageView * imagePlay;
		[Export("imagePlay", ArgumentSemantic.Strong)]
		UIImageView ImagePlay { get; set; }

		// @property (nonatomic, strong) UIImageView * imageManual;
		[Export("imageManual", ArgumentSemantic.Strong)]
		UIImageView ImageManual { get; set; }

		// @property (nonatomic, strong) UIActivityIndicatorView * spinner;
		[Export("spinner", ArgumentSemantic.Strong)]
		UIActivityIndicatorView Spinner { get; set; }

		// -(void)bindData:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Export("bindData:messagesView:")]
		void BindData(NSIndexPath indexPath, RCMessagesView messagesView);

		// +(CGFloat)height:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Static]
		[Export("height:messagesView:")]
		nfloat Height(NSIndexPath indexPath, RCMessagesView messagesView);
	}

	// @interface RCStatusCell : UITableViewCell
	[BaseType(typeof(UITableViewCell))]
	interface RCStatusCell
	{
		// @property (nonatomic, strong) UIView * viewBubble;
		[Export("viewBubble", ArgumentSemantic.Strong)]
		UIView ViewBubble { get; set; }

		// @property (nonatomic, strong) UITextView * textView;
		[Export("textView", ArgumentSemantic.Strong)]
		UITextView TextView { get; set; }

		// -(void)bindData:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Export("bindData:messagesView:")]
		void BindData(NSIndexPath indexPath, RCMessagesView messagesView);

		// +(CGFloat)height:(NSIndexPath *)indexPath messagesView:(RCMessagesView *)messagesView;
		[Static]
		[Export("height:messagesView:")]
		nfloat Height(NSIndexPath indexPath, RCMessagesView messagesView);
	}

	//[Static]
	//[Verify(ConstantsInterfaceAssociation)]
	//partial interface Constants
	//{
	//	// extern double RCMessageKitVersionNumber;
	//	[Field("RCMessageKitVersionNumber", "__Internal")]
	//	double RCMessageKitVersionNumber { get; }

	//	// extern const unsigned char [] RCMessageKitVersionString;
	//	[Field("RCMessageKitVersionString", "__Internal")]
	//	byte[] RCMessageKitVersionString { get; }
	//}
}
