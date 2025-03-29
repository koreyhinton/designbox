import { css, html, LitElement } from "lit";
import { customElement, property } from "lit/decorators.js";

@customElement("text-adventure-game-shell")
export class TextAdventureGameShell extends LitElement {
  @property({ type: Number }) accessor sceneIndex: number = 1;
  @property({ type: String }) accessor command: string = "";
  @property({ type: String }) accessor autocomplete: string = "";

  scenes = [
    {},
    {
        actions: [
            { text: "weave through the forest" },
            { text: "examine the water" },
        ]
    },
    {
        actions: [
            { text: "explore the road" },
            { text: "weave through the forest" },
        ]
    },
    {
        actions: [
            { text: "read the park sign" },
            { text: "explore the road" },
        ]
    },
  ];

  updated(changedProperties: Map<string | number | symbol, unknown>) {
    if (!changedProperties.has("sceneIndex") && !changedProperties.has("command")) {
        return;
    }
    const scene = this.scenes[this.sceneIndex];
    console.log("has update", this.command.length, this.sceneIndex, scene.actions);
    this.autocomplete = "";
    if (this.command.length == 0) {
        this.autocomplete = (scene?.actions ?? []).map((a) => a.text[0]).join(",");
    } else {
        var actions = (scene?.actions ?? []);
        for (var i=0; i<actions.length; i++) {
          if (actions[i].text.startsWith(this.command)) {
            this.autocomplete = actions[i].text;
            break;
          }
        }
    }
  }

  static styles = css`
    :host {
      display: block;
      position: relative;
    }
    input[type="text"] {
      position: absolute;
      top: 0;
      left: 10px;
      width: 250px;
    }
    input[overlay] {
      opacity: 0.3;
      pointer-events: none;
    }
    input[prompt] {
      opacity: 0.3;
    }
  `;

  render() {
    return html`
      &gt; <span><input prompt type="text" .value="${this.command}" @input="${(e)=>{this.command = e.target.value;}}"/><input overlay type="text" @input="${(e)=>{this.autocomplete = e.target.value;}}" .value=${this.autocomplete}/></span>
    `;
  }

}
