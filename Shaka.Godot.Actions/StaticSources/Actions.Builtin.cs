internal static partial class Builtin
{
	/// <summary>
	/// Default InputEventAction to confirm a focused button, menu or list item, or validate input.
	/// </summary>
	internal static global::Godot.StringName UiAccept = "ui_accept";

	/// <summary>
	/// Default InputEventAction to start or end a drag-and-drop operation without using mouse.
	/// </summary>
	internal static global::Godot.StringName UiAccessibilityDragAndDrop = "ui_accessibility_drag_and_drop";

	/// <summary>
	/// Default InputEventAction to discard a modal or pending input.
	/// </summary>
	internal static global::Godot.StringName UiCancel = "ui_cancel";

	/// <summary>
	/// Default InputEventAction to delete a color preset in a ColorPicker.
	/// </summary>
	internal static global::Godot.StringName UiColorpickerDeletePreset = "ui_colorpicker_delete_preset";

	/// <summary>
	/// Default InputEventAction to copy a selection to the clipboard.
	/// </summary>
	internal static global::Godot.StringName UiCopy = "ui_copy";

	/// <summary>
	/// Default InputEventAction to cut a selection to the clipboard.
	/// </summary>
	internal static global::Godot.StringName UiCut = "ui_cut";

	/// <summary>
	/// Default InputEventAction to move down in the UI.
	/// </summary>
	internal static global::Godot.StringName UiDown = "ui_down";

	/// <summary>
	/// Default InputEventAction to go to the end position of a Control (e.g. last item in an ItemList or a Tree), matching the behavior of KEY_END on typical desktop UI systems.
	/// </summary>
	internal static global::Godot.StringName UiEnd = "ui_end";

	/// <summary>
	/// Default InputEventAction to refresh the contents of the current directory of a FileDialog.
	/// </summary>
	internal static global::Godot.StringName UiFiledialogRefresh = "ui_filedialog_refresh";

	/// <summary>
	/// Default InputEventAction to toggle showing hidden files and directories in a FileDialog.
	/// </summary>
	internal static global::Godot.StringName UiFiledialogShowHidden = "ui_filedialog_show_hidden";

	/// <summary>
	/// Default InputEventAction to go up one directory in a FileDialog.
	/// </summary>
	internal static global::Godot.StringName UiFiledialogUpOneLevel = "ui_filedialog_up_one_level";

	/// <summary>
	/// Default InputEventAction to switch TextEdit input/ui_text_indent between moving keyboard focus to the next Control in the scene and inputting a Tab character.
	/// </summary>
	internal static global::Godot.StringName UiFocusMode = "ui_focus_mode";

	/// <summary>
	/// Default InputEventAction to focus the next Control in the scene. The focus behavior can be configured via Control.focus_next.
	/// </summary>
	internal static global::Godot.StringName UiFocusNext = "ui_focus_next";

	/// <summary>
	/// Default InputEventAction to focus the previous Control in the scene. The focus behavior can be configured via Control.focus_previous.
	/// </summary>
	internal static global::Godot.StringName UiFocusPrev = "ui_focus_prev";

	/// <summary>
	/// Default InputEventAction to delete a GraphNode in a GraphEdit.
	/// </summary>
	internal static global::Godot.StringName UiGraphDelete = "ui_graph_delete";

	/// <summary>
	/// Default InputEventAction to duplicate a GraphNode in a GraphEdit.
	/// </summary>
	internal static global::Godot.StringName UiGraphDuplicate = "ui_graph_duplicate";

	/// <summary>
	/// Default InputEventAction to follow a GraphNode input port connection.
	/// </summary>
	internal static global::Godot.StringName UiGraphFollowLeft = "ui_graph_follow_left";

	/// <summary>
	/// macOS specific override for the shortcut to follow a GraphNode input port connection.
	/// </summary>
	internal static global::Godot.StringName UiGraphFollowLeftMacos = "ui_graph_follow_left.macos";

	/// <summary>
	/// Default InputEventAction to follow a GraphNode output port connection.
	/// </summary>
	internal static global::Godot.StringName UiGraphFollowRight = "ui_graph_follow_right";

	/// <summary>
	/// macOS specific override for the shortcut to follow a GraphNode output port connection.
	/// </summary>
	internal static global::Godot.StringName UiGraphFollowRightMacos = "ui_graph_follow_right.macos";

	/// <summary>
	/// Default InputEventAction to go to the start position of a Control (e.g. first item in an ItemList or a Tree), matching the behavior of KEY_HOME on typical desktop UI systems.
	/// </summary>
	internal static global::Godot.StringName UiHome = "ui_home";

	/// <summary>
	/// Default InputEventAction to move left in the UI.
	/// </summary>
	internal static global::Godot.StringName UiLeft = "ui_left";

	/// <summary>
	/// Default InputEventAction to open a context menu in a text field.
	/// </summary>
	internal static global::Godot.StringName UiMenu = "ui_menu";

	/// <summary>
	/// Default InputEventAction to go down a page in a Control (e.g. in an ItemList or a Tree), matching the behavior of KEY_PAGEDOWN on typical desktop UI systems.
	/// </summary>
	internal static global::Godot.StringName UiPageDown = "ui_page_down";

	/// <summary>
	/// Default InputEventAction to go up a page in a Control (e.g. in an ItemList or a Tree), matching the behavior of KEY_PAGEUP on typical desktop UI systems.
	/// </summary>
	internal static global::Godot.StringName UiPageUp = "ui_page_up";

	/// <summary>
	/// Default InputEventAction to paste from the clipboard.
	/// </summary>
	internal static global::Godot.StringName UiPaste = "ui_paste";

	/// <summary>
	/// Default InputEventAction to redo an undone action.
	/// </summary>
	internal static global::Godot.StringName UiRedo = "ui_redo";

	/// <summary>
	/// Default InputEventAction to move right in the UI.
	/// </summary>
	internal static global::Godot.StringName UiRight = "ui_right";

	/// <summary>
	/// Default InputEventAction to select an item in a Control (e.g. in an ItemList or a Tree).
	/// </summary>
	internal static global::Godot.StringName UiSelect = "ui_select";

	/// <summary>
	/// Default InputEventAction to swap input direction, i.e. change between left-to-right to right-to-left modes. Affects text-editing controls (LineEdit, TextEdit).
	/// </summary>
	internal static global::Godot.StringName UiSwapInputDirection = "ui_swap_input_direction";

	/// <summary>
	/// Searches for the next occurrence of the selection and adds a caret. If no selection is active, selects the word under the caret.
	/// The viewport is adjusted to the latest newly added caret.
	/// </summary>
	internal static global::Godot.StringName UiTextAddSelectionForNextOccurrence = "ui_text_add_selection_for_next_occurrence";

	/// <summary>
	/// Default InputEventAction to delete the character before the text cursor.
	/// </summary>
	internal static global::Godot.StringName UiTextBackspace = "ui_text_backspace";

	/// <summary>
	/// Default InputEventAction to delete all text before the text cursor.
	/// </summary>
	internal static global::Godot.StringName UiTextBackspaceAllToLeft = "ui_text_backspace_all_to_left";

	/// <summary>
	/// macOS specific override for the shortcut to delete all text before the text cursor.
	/// </summary>
	internal static global::Godot.StringName UiTextBackspaceAllToLeftMacos = "ui_text_backspace_all_to_left.macos";

	/// <summary>
	/// Default InputEventAction to delete all characters before the cursor up until a whitespace or punctuation character.
	/// </summary>
	internal static global::Godot.StringName UiTextBackspaceWord = "ui_text_backspace_word";

	/// <summary>
	/// macOS specific override for the shortcut to delete a word.
	/// </summary>
	internal static global::Godot.StringName UiTextBackspaceWordMacos = "ui_text_backspace_word.macos";

	/// <summary>
	/// Default InputEventAction to add an additional caret above every caret of a text.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretAddAbove = "ui_text_caret_add_above";

	/// <summary>
	/// macOS specific override for the shortcut to add a caret above every caret.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretAddAboveMacos = "ui_text_caret_add_above.macos";

	/// <summary>
	/// Default InputEventAction to add an additional caret below every caret of a text.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretAddBelow = "ui_text_caret_add_below";

	/// <summary>
	/// macOS specific override for the shortcut to add a caret below every caret.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretAddBelowMacos = "ui_text_caret_add_below.macos";

	/// <summary>
	/// Default InputEventAction to move the text cursor to the end of the text.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretDocumentEnd = "ui_text_caret_document_end";

	/// <summary>
	/// macOS specific override for the shortcut to move the text cursor to the end of the text.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretDocumentEndMacos = "ui_text_caret_document_end.macos";

	/// <summary>
	/// Default InputEventAction to move the text cursor to the start of the text.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretDocumentStart = "ui_text_caret_document_start";

	/// <summary>
	/// macOS specific override for the shortcut to move the text cursor to the start of the text.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretDocumentStartMacos = "ui_text_caret_document_start.macos";

	/// <summary>
	/// Default InputEventAction to move the text cursor down.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretDown = "ui_text_caret_down";

	/// <summary>
	/// Default InputEventAction to move the text cursor left.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretLeft = "ui_text_caret_left";

	/// <summary>
	/// Default InputEventAction to move the text cursor to the end of the line.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretLineEnd = "ui_text_caret_line_end";

	/// <summary>
	/// macOS specific override for the shortcut to move the text cursor to the end of the line.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretLineEndMacos = "ui_text_caret_line_end.macos";

	/// <summary>
	/// Default InputEventAction to move the text cursor to the start of the line.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretLineStart = "ui_text_caret_line_start";

	/// <summary>
	/// macOS specific override for the shortcut to move the text cursor to the start of the line.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretLineStartMacos = "ui_text_caret_line_start.macos";

	/// <summary>
	/// Default InputEventAction to move the text cursor down one page.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretPageDown = "ui_text_caret_page_down";

	/// <summary>
	/// Default InputEventAction to move the text cursor up one page.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretPageUp = "ui_text_caret_page_up";

	/// <summary>
	/// Default InputEventAction to move the text cursor right.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretRight = "ui_text_caret_right";

	/// <summary>
	/// Default InputEventAction to move the text cursor up.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretUp = "ui_text_caret_up";

	/// <summary>
	/// Default InputEventAction to move the text cursor left to the next whitespace or punctuation.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretWordLeft = "ui_text_caret_word_left";

	/// <summary>
	/// macOS specific override for the shortcut to move the text cursor back one word.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretWordLeftMacos = "ui_text_caret_word_left.macos";

	/// <summary>
	/// Default InputEventAction to move the text cursor right to the next whitespace or punctuation.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretWordRight = "ui_text_caret_word_right";

	/// <summary>
	/// macOS specific override for the shortcut to move the text cursor forward one word.
	/// </summary>
	internal static global::Godot.StringName UiTextCaretWordRightMacos = "ui_text_caret_word_right.macos";

	/// <summary>
	/// Clears selection or removes secondary carets and their selections.
	/// </summary>
	internal static global::Godot.StringName UiTextClearCaretsAndSelection = "ui_text_clear_carets_and_selection";

	/// <summary>
	/// Default InputEventAction to accept an autocompletion hint.
	/// </summary>
	internal static global::Godot.StringName UiTextCompletionAccept = "ui_text_completion_accept";

	/// <summary>
	/// Default InputEventAction to request autocompletion.
	/// </summary>
	internal static global::Godot.StringName UiTextCompletionQuery = "ui_text_completion_query";

	/// <summary>
	/// Default InputEventAction to accept an autocompletion hint, replacing existing text.
	/// </summary>
	internal static global::Godot.StringName UiTextCompletionReplace = "ui_text_completion_replace";

	/// <summary>
	/// Default InputEventAction to unindent text.
	/// </summary>
	internal static global::Godot.StringName UiTextDedent = "ui_text_dedent";

	/// <summary>
	/// Default InputEventAction to delete the character after the text cursor.
	/// </summary>
	internal static global::Godot.StringName UiTextDelete = "ui_text_delete";

	/// <summary>
	/// Default InputEventAction to delete all text after the text cursor.
	/// </summary>
	internal static global::Godot.StringName UiTextDeleteAllToRight = "ui_text_delete_all_to_right";

	/// <summary>
	/// macOS specific override for the shortcut to delete all text after the text cursor.
	/// </summary>
	internal static global::Godot.StringName UiTextDeleteAllToRightMacos = "ui_text_delete_all_to_right.macos";

	/// <summary>
	/// Default InputEventAction to delete all characters after the cursor up until a whitespace or punctuation character.
	/// </summary>
	internal static global::Godot.StringName UiTextDeleteWord = "ui_text_delete_word";

	/// <summary>
	/// macOS specific override for the shortcut to delete a word after the text cursor.
	/// </summary>
	internal static global::Godot.StringName UiTextDeleteWordMacos = "ui_text_delete_word.macos";

	/// <summary>
	/// Default InputEventAction to indent the current line.
	/// </summary>
	internal static global::Godot.StringName UiTextIndent = "ui_text_indent";

	/// <summary>
	/// Default InputEventAction to insert a new line at the position of the text cursor.
	/// </summary>
	internal static global::Godot.StringName UiTextNewline = "ui_text_newline";

	/// <summary>
	/// Default InputEventAction to insert a new line before the current one.
	/// </summary>
	internal static global::Godot.StringName UiTextNewlineAbove = "ui_text_newline_above";

	/// <summary>
	/// Default InputEventAction to insert a new line after the current one.
	/// </summary>
	internal static global::Godot.StringName UiTextNewlineBlank = "ui_text_newline_blank";

	/// <summary>
	/// Default InputEventAction to scroll down one line of text.
	/// </summary>
	internal static global::Godot.StringName UiTextScrollDown = "ui_text_scroll_down";

	/// <summary>
	/// macOS specific override for the shortcut to scroll down one line.
	/// </summary>
	internal static global::Godot.StringName UiTextScrollDownMacos = "ui_text_scroll_down.macos";

	/// <summary>
	/// Default InputEventAction to scroll up one line of text.
	/// </summary>
	internal static global::Godot.StringName UiTextScrollUp = "ui_text_scroll_up";

	/// <summary>
	/// macOS specific override for the shortcut to scroll up one line.
	/// </summary>
	internal static global::Godot.StringName UiTextScrollUpMacos = "ui_text_scroll_up.macos";

	/// <summary>
	/// Default InputEventAction to select all text.
	/// </summary>
	internal static global::Godot.StringName UiTextSelectAll = "ui_text_select_all";

	/// <summary>
	/// Selects the word under the caret if no selection is active. Deselects the current selection if one is active.
	/// </summary>
	internal static global::Godot.StringName UiTextSelectWordUnderCaret = "ui_text_select_word_under_caret";

	/// <summary>
	/// macOS specific override for the shortcut to select the word currently under the caret.
	/// </summary>
	internal static global::Godot.StringName UiTextSelectWordUnderCaretMacos = "ui_text_select_word_under_caret.macos";

	/// <summary>
	/// Searches for the next occurrence of the word or selection and moves the caret. Adjusts viewport accordingly.
	/// </summary>
	internal static global::Godot.StringName UiTextSkipSelectionForNextOccurrence = "ui_text_skip_selection_for_next_occurrence";

	/// <summary>
	/// Default InputEventAction to submit a text field.
	/// </summary>
	internal static global::Godot.StringName UiTextSubmit = "ui_text_submit";

	/// <summary>
	/// Default InputEventAction to toggle insert mode in a text field. In insert mode, new text overrides the character after the cursor unless it's a newline.
	/// </summary>
	internal static global::Godot.StringName UiTextToggleInsertMode = "ui_text_toggle_insert_mode";

	/// <summary>
	/// Default InputEventAction to undo the most recent action.
	/// </summary>
	internal static global::Godot.StringName UiUndo = "ui_undo";

	/// <summary>
	/// Default InputEventAction to start Unicode character hexadecimal code input in a text field.
	/// </summary>
	internal static global::Godot.StringName UiUnicodeStart = "ui_unicode_start";

	/// <summary>
	/// Default InputEventAction to move up in the UI.
	/// </summary>
	internal static global::Godot.StringName UiUp = "ui_up";
}
